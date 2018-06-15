Public Class Parametro
  Inherits EntidadConEstado

  Public Shared Function Crear(nombre As String, valor As String, consulta As Consulta) As Parametro
    Dim parametro = New Parametro(nombre, valor, consulta)
    parametro.MarcarComoNuevo()
    Return parametro
  End Function

  Public Shared Function Copiar(parametro As Parametro) As Parametro
    Dim copiaParametro As Parametro = Crear(parametro.Nombre, parametro.Valor, Nothing)
    copiaParametro.MarcarComoNuevo()
    Return copiaParametro
  End Function

  Protected Sub New()
  End Sub

  Private Sub New(nombre As String, valor As String, consulta As Consulta)
    Me.Nombre = nombre
    Me.Valor = valor
    Me.Consulta = consulta
    IdConsulta = consulta.Id
  End Sub

  Public Property Id As Integer
    Get
      Return _id
    End Get
    Private Set(value As Integer)
      _id = value
    End Set
  End Property
  Private _id As Integer

  Public Property Nombre As String
    Get
      Return _nombre
    End Get
    Private Set(value As String)
      _nombre = value
    End Set
  End Property
  Private _nombre As String

  Public Property Valor As String
    Get
      Return _valor
    End Get
    Private Set(value As String)
      _valor = value
    End Set
  End Property
  Private _valor As String

  Public Property IdConsulta As Integer?
    Get
      Return _idConsulta
    End Get
    Private Set(value As Integer?)
      _idConsulta = value
    End Set
  End Property
  Private _idConsulta As Integer?

  Public Property Consulta As Consulta
    Get
      Return _consulta
    End Get
    Private Set(value As Consulta)
      _consulta = value
    End Set
  End Property
  Private _consulta As Consulta

  Public Sub ModificarValor(valor As String)
    Me.Valor = valor
    MarcarModificadoSiNoNuevo()
  End Sub
End Class