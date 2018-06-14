Imports System.Linq.Expressions
Imports SupraReports.Model

Public Class Informe
  Inherits EntidadConEstado

  Protected Sub New()
  End Sub

  Public Sub New(nombre As String, usuario As String)
    Me.Nombre = nombre
    Me.Usuario = usuario
    _consultas = New List(Of Consulta)()
    MarcarComoNuevo()
  End Sub

  Public Sub New(informe As Informe)
    Me.New(informe.Nombre, informe.Usuario)
    For Each c In informe.ObtenerConsultasSinEliminar()
      Dim newC = New Consulta(c)
      AnadirConsulta(newC)
      'Dim newC = New Consulta(c) With {
      '  .Informe = Me,
      '  .IdInforme = Id
      '}
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

  Public Property Usuario As String
    Get
      Return _usuario
    End Get
    Set(value As String)
      _usuario = value
    End Set
  End Property
  Private _usuario As String

  Protected Overridable Property Consultas As ICollection(Of Consulta)

  Public Sub AnadirConsulta(consulta As Consulta)
    Consultas.Add(consulta)
  End Sub

  Public Sub EliminarConsulta(consulta As Consulta)
    consulta.MarcarComoEliminado()
    'Consultas.Remove(consulta)
  End Sub

  Public Function ObtenerConsultasSinEliminar() As IEnumerable(Of Consulta)
    Return Consultas.Where(Function(x) x.Estado <> EstadoEntidad.Eliminado).AsEnumerable()
  End Function

  Public Class Mappings
    Public Const ConsultaCollectionName = NameOf(Informe.Consultas)
    Public Shared ReadOnly Property Consultas As Expression(Of Func(Of Informe, ICollection(Of Consulta)))
      Get
        Return Function(x) x.Consultas
      End Get
    End Property
  End Class
End Class