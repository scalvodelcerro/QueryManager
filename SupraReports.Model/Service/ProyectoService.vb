Public Class ProyectoService

    Public Function ObtenerProyectosDeUsuario(nombreUsuario As String) As IList(Of Proyecto)
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Return db.Proyectos.AsNoTracking().
              Where(Function(x) x.Permisos.Any(Function(xx) xx.NombreUsuario = nombreUsuario)).
              OrderBy(Function(x) x.Nombre).
              ToList()
    End Using
  End Function

  Public Sub CrearProyecto(nombreProyecto As String, nombreUsuario As String)
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Dim nuevoProyecto = Proyecto.Crear(nombreProyecto)
      nuevoProyecto.AnadirPermisoUsuario(nombreUsuario, True)

      db.Proyectos.Add(nuevoProyecto)
      db.SaveChanges()
    End Using
  End Sub

  Public Function ObtenerPermisosUsuarios(idProyecto As Integer) As DataTable
    Using dao = GeneralDao.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Dim sql As String = My.Resources.query_permisos_usuarios
      sql = sql.Replace(":idProyecto", idProyecto.ToString())
      Return dao.EjecutarSelect(sql)
    End Using
  End Function

  Sub GuardarPermisoUsuario(idProyecto As Integer, nombreUsuario As String, esAdministrador As Boolean)
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Dim entityUsuario = db.Usuarios.Find(nombreUsuario)
      If entityUsuario Is Nothing Then
        entityUsuario = New Usuario(nombreUsuario)
        db.Usuarios.Add(entityUsuario)
      End If

      Dim entity = db.PermisosUsuario.SingleOrDefault(Function(x) x.IdProyecto = idProyecto AndAlso x.NombreUsuario = nombreUsuario)
      If entity Is Nothing Then
        entity = New PermisoUsuario(nombreUsuario, esAdministrador, idProyecto)
        db.PermisosUsuario.Add(entity)
      Else
        entity.Administrador = esAdministrador
      End If
      db.SaveChanges()
    End Using
  End Sub

  Sub EliminarPermisoUsuario(IdProyecto As Integer, nombreUsuario As String)
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Dim entity = db.PermisosUsuario.SingleOrDefault(Function(x) x.IdProyecto = IdProyecto AndAlso x.NombreUsuario = nombreUsuario)
      If entity IsNot Nothing Then
        db.PermisosUsuario.Remove(entity)
        db.SaveChanges()
      End If
    End Using
  End Sub

End Class
