Public Class FormConfiguracion
  Private Sub FormConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If String.IsNullOrEmpty(My.Settings.RutaDirectorioSalida) Then
      TbDirectorioSalida.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Else
      TbDirectorioSalida.Text = My.Settings.RutaDirectorioSalida
    End If
  End Sub

  Private Sub BtnExaminarDirectorioSalida_Click(sender As Object, e As EventArgs) Handles BtnExaminarDirectorioSalida.Click
    FolderDialog.SelectedPath = TbDirectorioSalida.Text
    If FolderDialog.ShowDialog(Me) = DialogResult.OK Then
      TbDirectorioSalida.Text = FolderDialog.SelectedPath
    End If
  End Sub

  Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
    My.Settings.RutaDirectorioSalida = TbDirectorioSalida.Text
  End Sub
End Class