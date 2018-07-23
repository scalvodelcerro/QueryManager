Public Class PermisoUsuario

  Public Sub New(nombreUsuario As String, administrador As Boolean, idProyecto As Integer)
    Me.NombreUsuario = nombreUsuario
    Me.Administrador = administrador
    Me.IdProyecto = idProyecto
  End Sub

  Protected Sub New()
  End Sub

  Public Property NombreUsuario As String
  Public Overridable Property Usuario As Usuario
  Public Property IdProyecto As Integer
  Public Overridable Property Proyecto As Proyecto
  Public Property Administrador As Boolean

End Class
