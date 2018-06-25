Public Class PermisoUsuario
  Public Sub New(usuario As String, administrador As Boolean, proyecto As Proyecto)
    Me.Usuario = usuario
    Me.Administrador = administrador
    Me.Proyecto = proyecto
  End Sub

  Public Property Usuario As String
  Public Property Administrador As Boolean
  Public Overridable Property IdProyecto As Integer
  Public Overridable Property Proyecto As Proyecto
End Class
