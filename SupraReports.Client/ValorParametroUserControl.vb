Public Class ValorParametroUserControl
  Public Event CambiarValor As EventHandler(Of CambiarValorEventArgs)

  Private Sub TbValor_TextChanged(sender As Object, e As EventArgs) Handles TbValor.TextChanged
    RaiseEvent CambiarValor(Me, New CambiarValorEventArgs(TbParametro.Text, TbValor.Text))
  End Sub

  Public Class CambiarValorEventArgs
    Inherits EventArgs

    Public Sub New(parametro As String, valor As String)
      Me.Parametro = parametro
      Me.Valor = valor
    End Sub

    Public Property Parametro As String
    Public Property Valor As String
  End Class

End Class
