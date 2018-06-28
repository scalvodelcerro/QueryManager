Public Class UsuarioService
  Public Function EsAdministradorProyecto(nombreUsuario As String, idProyecto As Integer) As Boolean
    If idProyecto <= 0 Then Return False
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Return (From pr As Proyecto In db.Proyectos.AsNoTracking()
              Where pr.Id = idProyecto AndAlso
               pr.Permisos.Any(Function(x) x.NombreUsuario = nombreUsuario AndAlso x.Administrador)).Any()
    End Using
  End Function
End Class
