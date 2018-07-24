Imports SupraReports.Model

Public Class FormProgramaciones
    Private informeService As InformeService = New InformeService()
    Private nombreUsuario As String

    Public Sub New(nombreUsuario As String)
        InitializeComponent()
        Me.nombreUsuario = nombreUsuario
    End Sub

    Private Sub FormProgramaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ProgramacionBindingSource.DataSource = informeService.ObtenerProgramacionesDeUsuario(nombreUsuario)
    InformeBindingSource.DataSource = informeService.ObtenerInformesDeUsuario(nombreUsuario)
  End Sub

  Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        GridProgramaciones.EndEdit()
    informeService.GuardarProgramaciones(ProgramacionBindingSource.DataSource, nombreUsuario)
  End Sub

  Private Sub GridProgramaciones_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles GridProgramaciones.DataError
    Console.WriteLine(e.Exception.Message)
    Dim value = GridProgramaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    If Not CType(GridProgramaciones.Columns(e.ColumnIndex), DataGridViewComboBoxColumn).Items.Contains(value) Then
      GridProgramaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value =
        CType(GridProgramaciones.Columns(e.ColumnIndex), DataGridViewComboBoxColumn).Items.Cast(Of Informe).First().Id
      e.ThrowException = False
    End If
  End Sub

  Private Sub InformeBindingSource_DataError(sender As Object, e As BindingManagerDataErrorEventArgs) Handles InformeBindingSource.DataError
    Console.WriteLine(e.Exception.Message)
  End Sub
End Class
