Public Class Parametro

  Public Shared Function Crear(nombre As String, valor As String, consulta As Consulta) As Parametro
    Return New Parametro(nombre, valor, consulta)
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
  Public Overridable Property Nombre As String
  Public Overridable Property Valor As String
  Public Property Consulta As Consulta

  Public Class ParametrosDefecto
    Public Const HOY As String = "HOY"
    Public Const AYER As String = "AYER"

    Public Shared ReadOnly Property Todos As IEnumerable(Of String)
      Get
        Return {HOY, AYER}
      End Get
    End Property

    Public Shared Function ObtenerValor(nombre As String) As String
      Select Case nombre
        Case HOY
          Return DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss")
        Case AYER
          Return DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss")
        Case Else
          Return Nothing
      End Select
    End Function
  End Class
End Class
