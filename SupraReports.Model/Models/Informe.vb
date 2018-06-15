Imports System.Linq.Expressions

Public Class Informe
  Inherits EntidadConEstado

  Public Shared Function Crear(nombre As String, usuario As String) As Informe
    Dim informe As Informe = New Informe(nombre, usuario)
    informe.MarcarComoNuevo()
    Return informe
  End Function

  Public Shared Function Copiar(informe As Informe) As Informe
    Dim copiaInforme As Informe = Crear(informe.Nombre, informe.Usuario)
    For Each c In informe.ObtenerConsultasSinEliminar()
      Dim copiaConsulta As Consulta = Consulta.Copiar(c)
      copiaInforme.AnadirConsulta(copiaConsulta)
    Next
    copiaInforme.MarcarComoNuevo()
    Return copiaInforme
  End Function

  Protected Sub New()
  End Sub

  Private Sub New(nombre As String, usuario As String)
    Me.Nombre = nombre
    Me.Usuario = usuario
    _Consultas = New List(Of Consulta)()
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

  Public Function TieneCambios() As Boolean
    If Estado <> EstadoEntidad.SinCambios Then Return True
    Return Consultas.Any(Function(x) x.TieneCambios())
  End Function

  Public Sub ModificarNombre(nombre As String)
    Me.Nombre = nombre
    MarcarModificadoSiNoNuevo()
  End Sub

  Public Sub AnadirConsulta(consulta As Consulta)
    consulta.AsignarInforme(Me)
    Consultas.Add(consulta)
  End Sub

  Public Sub EliminarConsulta(consulta As Consulta)
    If consulta.Estado = EstadoEntidad.Nuevo Then
      Consultas.Remove(consulta)
    Else
      consulta.MarcarComoEliminado()
    End If
  End Sub

  Public Function ObtenerTodasConsultas() As IEnumerable(Of Consulta)
    Return Consultas.ToList()
  End Function

  Public Function ObtenerConsultasSinEliminar() As IEnumerable(Of Consulta)
    Return Consultas.Where(Function(x) x.Estado <> EstadoEntidad.Eliminado).ToList()
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