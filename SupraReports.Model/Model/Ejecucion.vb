Public Class Ejecucion
  Public Shared Function Crear(resultado As String, rutaFichero As String, idInforme As Integer, nombreUsuario As String) As Ejecucion
    Return New Ejecucion(resultado, rutaFichero, idInforme, nombreUsuario)
  End Function

  Protected Sub New()
    HoraEjecucion = DateTime.Now
  End Sub

  Private Sub New(resultado As String, rutaFichero As String, idInforme As Integer, nombreUsuario As String)
    Me.New()
    Me.Resultado = resultado
    Me.RutaFichero = rutaFichero
    Me.NombreUsuario = nombreUsuario
    Me.IdInforme = idInforme
  End Sub

  Public Property Id As Integer
  Public Property HoraEjecucion As DateTime
  Public Property Resultado As String
  Public Property RutaFichero As String
  Public Property IdInforme As Integer
  Public Property Informe As Informe
  Public Property NombreUsuario As String
  Public Property UsuarioEjecucion As Usuario

End Class
