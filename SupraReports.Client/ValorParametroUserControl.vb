Public Class ValorParametroUserControl

  Public Sub New(nombreParametro As String, valor As String)
    InitializeComponent()
    Me.NombreParametro = nombreParametro
    Me.Valor = valor
  End Sub

  Public Property NombreParametro As String
    Get
      Return LblNombre.Text
    End Get
    Set(value As String)
      LblNombre.Text = value
    End Set
  End Property

  Public Property Valor As String
    Get
      Return TbValor.Text
    End Get
    Set(value As String)
      TbValor.Text = value
    End Set
  End Property
End Class
