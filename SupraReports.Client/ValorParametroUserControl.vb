Public Class ValorParametroUserControl
  Public Property Parametro As String
    Get
      Return _nombreParametro
    End Get
    Set(value As String)
      _nombreParametro = value
      LblNombre.Text = String.Format("{0}:", _nombreParametro)
    End Set
  End Property
  Private _nombreParametro As String

  Public Property Valor As String
    Get
      Return _valor
    End Get
    Set(value As String)
      _valor = value
      TbValor.Text = _valor
    End Set
  End Property
  Private _valor As String

  Public Event CambiarValor As EventHandler(Of ValorParametroEventArgs)
  Public Event Seleccionar As EventHandler(Of ValorParametroEventArgs)
  Public Event Deseleccionar As EventHandler(Of ValorParametroEventArgs)

  Private Sub TbValor_TextChanged(sender As Object, e As EventArgs) Handles TbValor.TextChanged
    _valor = TbValor.Text
    RaiseEvent CambiarValor(Me, New ValorParametroEventArgs(Parametro, Valor))
  End Sub

  Private Sub TbValor_Enter(sender As Object, e As EventArgs) Handles TbValor.Enter
    RaiseEvent Seleccionar(Me, New ValorParametroEventArgs(Parametro, Valor))
  End Sub

  Private Sub TbValor_Leave(sender As Object, e As EventArgs) Handles TbValor.Leave
    RaiseEvent Deseleccionar(Me, New ValorParametroEventArgs(Parametro, Valor))
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
