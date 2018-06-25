Public Class Proyecto
  Public Shared Function Crear(nombre As String) As Proyecto
    Return New Proyecto(nombre)
  End Function

  Protected Sub New()
  End Sub

  Private Sub New(nombre As String)
    Me.Nombre = nombre
    Informes = New List(Of Informe)()
    Permisos = New List(Of PermisoUsuario)()
  End Sub

  Public Property Id As Integer
  Public Property Nombre As String
  Public Overridable Property Informes As ICollection(Of Informe)
  Public Overridable Property Permisos As ICollection(Of PermisoUsuario)
End Class
