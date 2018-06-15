Imports System.Linq.Expressions

Public Class Consulta
  Inherits EntidadConEstado

  Protected Sub New()
  End Sub

  Public Sub New(nombre As String, textoSql As String, informe As Informe)
    Me.Nombre = nombre
    Me.TextoSql = textoSql
    Me.Informe = informe
    IdInforme = informe.Id
    Parametros = New List(Of Parametro)()
    MarcarComoNuevo()
  End Sub

  Public Sub New(consulta As Consulta)
    Me.New(consulta.Nombre, consulta.TextoSql, consulta.Informe)
    For Each p In consulta.Parametros
      Dim newP = New Parametro(p)
      'Dim newP = New Parametro(p) With {
      '  .Consulta = Me,
      '  .IdConsulta = Id
      '}
      Parametros.Add(newP)
    Next
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

  Public Property TextoSql As String
    Get
      Return _textoSql
    End Get
    Private Set(value As String)
      _textoSql = value
    End Set
  End Property
  Private _textoSql As String

  Public Property IdInforme As Integer?
    Get
      Return _idInforme
    End Get
    Private Set(value As Integer?)
      _idInforme = value
    End Set
  End Property
  Private _idInforme As Integer?

  Public Property Informe As Informe
    Get
      Return _informe
    End Get
    Private Set(value As Informe)
      _informe = value
    End Set
  End Property
  Private _informe As Informe

  Protected Overridable Property Parametros As ICollection(Of Parametro)

  Public Function TieneCambios() As Boolean
    If Estado <> EstadoEntidad.SinCambios Then Return True
    Return Parametros.Any(Function(x) x.Estado <> EstadoEntidad.SinCambios)
  End Function

  Public Sub ModificarNombre(nombre As String)
    Me.Nombre = nombre
    MarcarModificadoSiNoNuevo()
  End Sub

  Public Sub ModificarTextoSql(textoSql As String)
    Me.TextoSql = textoSql
    MarcarModificadoSiNoNuevo()
  End Sub

  Public Sub AnadirParametro(parametro As Parametro)
    Parametros.Add(parametro)
  End Sub

  Public Sub EliminarParametro(parametro As Parametro)
    If parametro.Estado = EstadoEntidad.Nuevo Then
      Parametros.Remove(parametro)
    Else
      parametro.MarcarComoEliminado()
    End If
  End Sub

  Public Function ObtenerTodosParametros() As IEnumerable(Of Parametro)
    Return Parametros.ToList()
  End Function

  Public Function ObtenerParametrosSinEliminar() As IEnumerable(Of Parametro)
    Return Parametros.Where(Function(x) x.Estado <> EstadoEntidad.Eliminado).ToList()
  End Function

  Public Class Mappings
    Public Const ParametroCollectionName = NameOf(Consulta.Parametros)
    Public Shared ReadOnly Property Parametros As Expression(Of Func(Of Consulta, ICollection(Of Parametro)))
      Get
        Return Function(x) x.Parametros
      End Get
    End Property
  End Class

End Class