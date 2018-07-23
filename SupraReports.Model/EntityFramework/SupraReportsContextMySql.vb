Imports System.Data.Common
Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration
Imports MySql.Data.Entity

<DbConfigurationType(GetType(SupraReportsConfigurationMySql))>
Public Class SupraReportsContextMySql
  Inherits SupraReportsContext

  Public Sub New()
    MyBase.New(ConnectionManager.GetConnection(ConnectionType.MySql))
    If Not Database.Exists() Then
      Database.Create()
      InsertarDatosIniciales()
    End If
  End Sub

  Protected Sub InsertarDatosIniciales()
    Usuarios.Add(New Usuario("Sergio"))
    Usuarios.Add(New Usuario("Fulanito"))
    Usuarios.Add(New Usuario("Menganito"))
    SaveChanges()
    Dim proyecto1 = Proyecto.Crear("Proyecto 1")
    Proyectos.Add(proyecto1)
    Dim proyecto2 As Proyecto = Proyecto.Crear("Proyecto 2")
    Proyectos.Add(proyecto2)
    Dim proyecto3 As Proyecto = Proyecto.Crear("Proyecto 3")
    Proyectos.Add(proyecto3)
    SaveChanges()
    PermisosUsuario.Add(New PermisoUsuario("Sergio", True, proyecto1.Id))
    PermisosUsuario.Add(New PermisoUsuario("Sergio", False, proyecto3.Id))
    SaveChanges()
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityUsuario As EntityTypeConfiguration(Of Usuario))
    MyBase.ConfigurarEntity(entityUsuario)
    entityUsuario.
        ToTable(Naming.TABLA_USUARIO)
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityInforme As EntityTypeConfiguration(Of Informe))
    MyBase.ConfigurarEntity(entityInforme)
    entityInforme.
        ToTable(Naming.TABLA_INFORME)
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityConsulta As EntityTypeConfiguration(Of Consulta))
    MyBase.ConfigurarEntity(entityConsulta)
    entityConsulta.
        ToTable(Naming.TABLA_CONSULTA)
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityParametro As EntityTypeConfiguration(Of Parametro))
    MyBase.ConfigurarEntity(entityParametro)
    entityParametro.
        ToTable(Naming.TABLA_PARAMETRO)
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityProgramacion As EntityTypeConfiguration(Of Programacion))
    MyBase.ConfigurarEntity(entityProgramacion)
    entityProgramacion.
        ToTable(Naming.TABLA_PROGRAMACION)
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityEjecucion As EntityTypeConfiguration(Of Ejecucion))
    MyBase.ConfigurarEntity(entityEjecucion)
    entityEjecucion.
        ToTable(Naming.TABLA_EJECUCION)
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityProyecto As EntityTypeConfiguration(Of Proyecto))
    MyBase.ConfigurarEntity(entityProyecto)
    entityProyecto.
        ToTable(Naming.TABLA_PROYECTO)
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityPermisoUsuario As EntityTypeConfiguration(Of PermisoUsuario))
    MyBase.ConfigurarEntity(entityPermisoUsuario)
    entityPermisoUsuario.
        ToTable(Naming.TABLA_PERMISO_USUARIO)
  End Sub

  Protected Overrides Sub ConfigurarEntity(entityConfiguracionInforme As EntityTypeConfiguration(Of ConfiguracionInforme))
    MyBase.ConfigurarEntity(entityConfiguracionInforme)
    entityConfiguracionInforme.
        ToTable(Naming.TABLA_CONFIGURACION_INFORME)
  End Sub
End Class

Public Class SupraReportsHistoryContextMySql
  Inherits MySqlHistoryContext

  Public Sub New(existingConnection As DbConnection, defaultSchema As String)
    MyBase.New(existingConnection, defaultSchema)
  End Sub
End Class
