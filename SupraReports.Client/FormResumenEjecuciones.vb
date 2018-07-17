Imports System.Data.Entity
Imports System.IO
Imports SupraReports.Model

Public Class FormResumenEjecuciones
    Private nombreUsuario As String

    Public Sub New(nombreUsuario As String)
        InitializeComponent()
        Me.nombreUsuario = nombreUsuario
    End Sub

    Private Sub FormResumenEjecuciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
            EjecucionBindingSource.DataSource =
              db.Ejecuciones.Include("Informe.Proyecto").AsNoTracking().
              Where(Function(x) x.NombreUsuario = Me.nombreUsuario).
              OrderByDescending(Function(x) x.HoraEjecucion).
              ToList()
        End Using
    End Sub

    Private Sub GridEjecuciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridEjecuciones.CellContentClick
        If e.ColumnIndex = DataGridColumnRutaFichero.Index Then
            Dim fileName = GridEjecuciones(e.ColumnIndex, e.RowIndex).Value.ToString()
            If File.Exists(fileName) Then
                Process.Start(fileName)
            End If
        End If
    End Sub
End Class