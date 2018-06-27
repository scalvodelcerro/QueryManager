Imports SupraReports.Model

Public Class FormProgramaciones
  Private informeService As InformeService = New InformeService()
  Private Sub FormProgramaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ProgramacionBindingSource.DataSource = informeService.ObtenerProgramacionesDeUsuario(Environment.UserName)
  End Sub

  Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
    GridProgramaciones.EndEdit()
    informeService.GuardarProgramaciones(ProgramacionBindingSource.DataSource)
  End Sub
End Class
