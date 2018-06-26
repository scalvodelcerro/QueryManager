Public Class PermisoUsuario
  Public Sub New(nombreUsuario As String, administrador As Boolean, idProyecto As Integer)
    Me.NombreUsuario = nombreUsuario
    Me.Administrador = administrador
    Me.IdProyecto = idProyecto
  End Sub

  Protected Sub New()
  End Sub

  Public Property NombreUsuario As String
  Public Property Usuario As Usuario
  Public Property Administrador As Boolean
  Public Overridable Property IdProyecto As Integer
  Public Overridable Property Proyecto As Proyecto
End Class
