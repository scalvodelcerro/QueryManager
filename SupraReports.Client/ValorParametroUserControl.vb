Public Class ValorParametroUserControl
  Public Event CambiarValor As EventHandler(Of ValorParametroEventArgs)
  Public Event Seleccionar As EventHandler(Of ValorParametroEventArgs)

  Private Sub TbValor_TextChanged(sender As Object, e As EventArgs) Handles TbValor.TextChanged
    RaiseEvent CambiarValor(Me, New ValorParametroEventArgs(TbParametro.Text, TbValor.Text))
  End Sub

  Private Sub TbValor_Enter(sender As Object, e As EventArgs) Handles TbValor.Enter, TbParametro.Enter
    RaiseEvent Seleccionar(Me, New ValorParametroEventArgs(TbParametro.Text, TbValor.Text))
  End Sub

  Public Class ValorParametroEventArgs
    Inherits EventArgs

    Public Sub New(parametro As String, valor As String)
      Me.Parametro = parametro
      Me.Valor = valor
    End Sub

    Public Property Parametro As String
    Public Property Valor As String
  End Class
End Class
