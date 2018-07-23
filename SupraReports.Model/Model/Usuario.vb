Public Class Usuario
  Public Sub New(nombre As String)
    Me.Nombre = nombre
  End Sub

  Protected Sub New()
  End Sub

  Public Property Nombre As String
  Public Property MaximoNumeroFilasConsulta As Integer
  Public Property RutaFicheroDefecto As String

End Class
