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
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        GridProgramaciones.EndEdit()
        informeService.GuardarProgramaciones(ProgramacionBindingSource.DataSource)
    End Sub
End Class
