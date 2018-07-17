Imports SupraReports.Model

Public Class FormConfiguracionInforme

    Private informe As Informe
    Private informeService As InformeService
    Dim nombreUsuario As String

    Public Sub New(informe As Informe, nombreUsuario As String)
        InitializeComponent()
        Me.informe = informe
        Me.nombreUsuario = nombreUsuario
        informeService = New InformeService()
    End Sub

    Private Sub FormConfiguracionInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If informe IsNot Nothing Then
            Dim confInforme = informeService.ObtenerConfiguracionInforme(informe.Id, nombreUsuario)
            If confInforme IsNot Nothing Then
                TbDirectorioSalida.Text = confInforme.RutaFichero
            End If
        End If
    End Sub

    Private Sub BtnExaminarDirectorioSalida_Click(sender As Object, e As EventArgs) Handles BtnExaminarDirectorioSalida.Click
        FolderDialog.SelectedPath = TbDirectorioSalida.Text
        If FolderDialog.ShowDialog(Me) = DialogResult.OK Then
            TbDirectorioSalida.Text = FolderDialog.SelectedPath
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim confInforme As ConfiguracionInforme = New ConfiguracionInforme()
        confInforme.IdInforme = informe.Id
        confInforme.NombreUsuario = Me.nombreUsuario
        confInforme.RutaFichero = TbDirectorioSalida.Text
        informeService.GuardarConfiguracionInforme(confInforme)
    End Sub
End Class