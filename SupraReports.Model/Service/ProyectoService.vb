Public Class ProyectoService
  Public Function ObtenerProyectosDeUsuario(nombreUsuario As String) As IList(Of Proyecto)
    Using db = New SupraReportsContext()
      Return db.Proyectos.AsNoTracking().
        Where(Function(x) x.Permisos.Any(Function(xx) xx.NombreUsuario = nombreUsuario)).
        ToList()
    End Using
  End Function
End Class
