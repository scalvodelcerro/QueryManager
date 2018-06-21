Imports System.Data.Entity
Imports System.IO
Imports SupraReports.Model

Public Class FormResumenEjecuciones
  Private horaDesde As DateTime

  Public Sub New(horaDesde As DateTime)
    InitializeComponent()
    Me.horaDesde = horaDesde
  End Sub

  Private Sub FormResumenEjecuciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Using db = New SupraReportsContext()
      EjecucionBindingSource.DataSource = db.Ejecuciones.Local.ToBindingList()
      db.Ejecuciones.Include("Informe").Where(Function(x) x.HoraEjecucion >= horaDesde).Load()
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