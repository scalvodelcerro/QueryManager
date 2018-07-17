Imports SupraReports.Model

Public Class FormConfiguracion
    Private usuario As Usuario
    Private usuarioService As UsuarioService

    Public Sub New(usuario As Usuario)
        InitializeComponent()
        Me.usuario = usuario
        usuarioService = New UsuarioService()
    End Sub

    Private Sub FormConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usuario IsNot Nothing AndAlso String.IsNullOrEmpty(usuario.RutaFicheroDefecto) Then
            TbDirectorioSalida.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Else
            TbDirectorioSalida.Text = usuario.RutaFicheroDefecto
        End If
    End Sub

    Private Sub BtnExaminarDirectorioSalida_Click(sender As Object, e As EventArgs) Handles BtnExaminarDirectorioSalida.Click
        FolderDialog.SelectedPath = TbDirectorioSalida.Text
        If FolderDialog.ShowDialog(Me) = DialogResult.OK Then
            TbDirectorioSalida.Text = FolderDialog.SelectedPath
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        usuario.RutaFicheroDefecto = TbDirectorioSalida.Text
        usuarioService.GuardarConfiguracion(Me.usuario)
    End Sub
End Class