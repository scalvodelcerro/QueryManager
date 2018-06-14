Public Class Parametro
  Inherits EntidadConEstado

  Protected Sub New()
  End Sub

  Public Sub New(nombre As String, valor As String, consulta As Consulta)
    Me.Nombre = nombre
    Me.Valor = valor
    Me.Consulta = consulta
    IdConsulta = consulta.Id
    MarcarComoNuevo()
  End Sub

  Public Sub New(parametro As Parametro)
    Me.New(parametro.Nombre, parametro.Valor, parametro.Consulta)
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