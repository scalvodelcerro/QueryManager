Public Class UsuarioService

    Public Function EsAdministradorProyecto(nombreUsuario As String, idProyecto As Integer) As Boolean
        If idProyecto <= 0 Then Return False
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Return db.PermisosUsuario.AsNoTracking().
        Where(Function(x) x.Administrador).
        Where(Function(x) x.IdProyecto = idProyecto).
        Where(Function(x) x.NombreUsuario = nombreUsuario).
        Any()
    End Using
  End Function

    Public Sub GuardarConfiguracion(usuario As Usuario)
        Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
            Dim entity = db.Usuarios.Find(usuario.Nombre)
            entity.RutaFicheroDefecto = usuario.RutaFicheroDefecto
            db.SaveChanges()
        End Using
    End Sub

    Public Function ObtenerRutaFicheroDefecto(nombreUsuario As String) As String
        Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
            Dim entity = db.Usuarios.Find(nombreUsuario)
            Return entity.RutaFicheroDefecto
        End Using
    End Function

End Class
