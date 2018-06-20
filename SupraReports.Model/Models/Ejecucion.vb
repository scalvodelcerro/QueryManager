Public Class Ejecucion
  Public Shared Function Crear(horaProgramada As String, resultado As String, rutaFichero As String, informe As Informe) As Ejecucion
    Return New Ejecucion(horaProgramada, resultado, rutaFichero, informe)
  End Function

  Private Sub New(horaProgramada As String, resultado As String, rutaFichero As String, informe As Informe)
    Me.HoraProgramada = horaProgramada
    Me.HoraEjecucion = Now
    Me.Resultado = resultado
    Me.RutaFichero = rutaFichero
    Me.Informe = informe
  End Sub

  Public Property Id As Integer
  Public Property HoraProgramada As String
  Public Property HoraEjecucion As DateTime
  Public Property Resultado As String
  Public Property RutaFichero As String
  Public Property Informe As Informe
End Class
