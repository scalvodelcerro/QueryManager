Public Class Ejecucion
    Public Shared Function Crear(resultado As String, rutaFichero As String, nombreUsuario As String, informe As Informe) As Ejecucion
        Return New Ejecucion(resultado, rutaFichero, nombreUsuario, informe)
    End Function

    Protected Sub New()
        HoraEjecucion = DateTime.Now
    End Sub

    Private Sub New(resultado As String, rutaFichero As String, nombreUsuario As String, informe As Informe)
        Me.New()
        Me.Resultado = resultado
        Me.RutaFichero = rutaFichero
        Me.NombreUsuario = nombreUsuario
        Me.Informe = informe
    End Sub

    Public Property Id As Integer
    Public Property HoraEjecucion As DateTime
    Public Property Resultado As String
    Public Property RutaFichero As String
    Public Property Informe As Informe
    Public Property NombreUsuario As String

End Class
