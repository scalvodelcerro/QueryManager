Public Class ConfiguracionInforme

  Public Sub New()
  End Sub

  Public Property IdInforme As Integer
  Public Overridable Property Informe As Informe
  Public Property NombreUsuario As String
  Public Overridable Property Usuario As Usuario

  Public Property RutaFichero As String

End Class
