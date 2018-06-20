Public Class Parametro

  Public Shared Function Crear(nombre As String, valor As String, consulta As Consulta) As Parametro
    Dim parametro = New Parametro(nombre, valor, consulta)
    Return parametro
  End Function

  Public Shared Function Copiar(parametro As Parametro) As Parametro
    Dim copiaParametro As Parametro = Crear(parametro.Nombre, parametro.Valor, Nothing)
    Return copiaParametro
  End Function

  Protected Sub New()
  End Sub

  Private Sub New(nombre As String, valor As String, consulta As Consulta)
    Me.Nombre = nombre
    Me.Valor = valor
    Me.Consulta = consulta
  End Sub

  Public Property Id As Integer
  Public Property Nombre As String
  Public Property Valor As String
  Public Property Consulta As Consulta
End Class