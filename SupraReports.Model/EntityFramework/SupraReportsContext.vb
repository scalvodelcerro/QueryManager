Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration
Imports MySql.Data.EntityFramework

<DbConfigurationType(GetType(MySqlEFConfiguration))>
Public Class SupraReportsContext
  Inherits DbContext

  Public Property Usuarios As DbSet(Of Usuario)
  Public Property Informes As DbSet(Of Informe)
  Public Property Consultas As DbSet(Of Consulta)
  Public Property Parametros As DbSet(Of Parametro)
  Public Property Programaciones As DbSet(Of Programacion)
  Public Property Ejecuciones As DbSet(Of Ejecucion)
  Public Property Proyectos As DbSet(Of Proyecto)

  Public Sub New()
    MyBase.New("name=SupraReports")
    If Not Database.Exists() Then
      Database.Create()
      InsertarDatosIniciales()
    End If
  End Sub

  Private Sub InsertarDatosIniciales()
    Usuarios.Add(New Usuario("Sergio"))
    Usuarios.Add(New Usuario("Fulanito"))
    Usuarios.Add(New Usuario("Menganito"))
    Dim proyecto1 = Proyecto.Crear("Proyecto 1")
    proyecto1.Permisos.Add(New PermisoUsuario("Sergio", True, proyecto1.Id))
    Proyectos.Add(proyecto1)
    Dim proyecto2 As Proyecto = Proyecto.Crear("Proyecto 2")
    Proyectos.Add(proyecto2)
    Dim proyecto3 As Proyecto = Proyecto.Crear("Proyecto 3")
    proyecto3.Permisos.Add(New PermisoUsuario("Sergio", False, proyecto3.Id))
    Proyectos.Add(proyecto3)
    SaveChanges()
  End Sub

  Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    MyBase.OnModelCreating(modelBuilder)
    ConfigurarEntity(modelBuilder.Entity(Of Usuario)())
    ConfigurarEntity(modelBuilder.Entity(Of Informe)())
    ConfigurarEntity(modelBuilder.Entity(Of Consulta)())
    ConfigurarEntity(modelBuilder.Entity(Of Parametro)())
    ConfigurarEntity(modelBuilder.Entity(Of Programacion)())
    ConfigurarEntity(modelBuilder.Entity(Of Ejecucion)())
    ConfigurarEntity(modelBuilder.Entity(Of Proyecto)())
    ConfigurarEntity(modelBuilder.Entity(Of PermisoUsuario)())
  End Sub

  Private Shared Sub ConfigurarEntity(entityUsuario As EntityTypeConfiguration(Of Usuario))
    entityUsuario.
      ToTable("Usuario").
      HasKey(Function(x) x.Nombre)
    entityUsuario.
      HasMany(Function(x) x.Permisos).
      WithRequired(Function(x) x.Usuario).
      HasForeignKey(Function(x) x.NombreUsuario).
      WillCascadeOnDelete()
    entityUsuario.
      Property(Function(x) x.Nombre).
        HasColumnName("Nombre_Usuario")
    entityUsuario.
      Property(Function(x) x.MaximoNumeroFilasConsulta).
        HasColumnName("Max_Rows_Query")
  End Sub

  Private Shared Sub ConfigurarEntity(entityInforme As EntityTypeConfiguration(Of Informe))
    entityInforme.
      ToTable("Informe").
      HasKey(Function(x) x.Id)
    entityInforme.
      HasRequired(Function(x) x.Usuario).
      WithMany(Function(x) x.Informes).
      HasForeignKey(Function(x) x.NombreUsuario).
      WillCascadeOnDelete()
    entityInforme.
      HasMany(Function(x) x.Consultas).
      WithRequired(Function(x) x.Informe).
      Map(Function(m) m.MapKey("Id_Informe")).
      WillCascadeOnDelete()
    entityInforme.
      HasRequired(Function(x) x.Programacion).
      WithRequiredPrincipal(Function(x) x.Informe).
      WillCascadeOnDelete()
    entityInforme.
      HasMany(Function(x) x.Ejecuciones).
      WithRequired(Function(x) x.Informe).
      Map(Function(m) m.MapKey("Id_Informe")).
      WillCascadeOnDelete()
    entityInforme.
      HasOptional(Function(x) x.Proyecto).
      WithMany(Function(x) x.Informes).
      Map(Function(x) x.MapKey("Id_Proyecto"))
    entityInforme.
      Property(Function(p) p.Id).
        HasColumnName("Id_Informe").
        HasColumnOrder(1)
    entityInforme.
      Property(Function(p) p.Nombre).
        HasMaxLength(100)
    entityInforme.
      Property(Function(p) p.NombreUsuario).
      HasColumnName("Nombre_Usuario")
  End Sub

  Private Shared Sub ConfigurarEntity(entityConsulta As EntityTypeConfiguration(Of Consulta))
    entityConsulta.
      ToTable("Consulta").
      HasMany(Function(x) x.Parametros).
      WithRequired(Function(x) x.Consulta).
      Map(Function(m) m.MapKey("Id_Consulta")).
      WillCascadeOnDelete()
    entityConsulta.
      Property(Function(p) p.Id).
        HasColumnName("Id_Consulta").
        HasColumnOrder(1)
    entityConsulta.
      Property(Function(p) p.Nombre).
        HasMaxLength(100)
    entityConsulta.
      Property(Function(p) p.TextoSql).
        HasColumnName("Texto_Sql")
  End Sub

  Private Shared Sub ConfigurarEntity(entityParametro As EntityTypeConfiguration(Of Parametro))
    entityParametro.
      ToTable("Parametro")
    entityParametro.
      Property(Function(p) p.Id).
        HasColumnName("Id_Parametro").
        HasColumnOrder(1)
    entityParametro.
      Property(Function(p) p.Nombre).
        HasMaxLength(25)
  End Sub

  Private Sub ConfigurarEntity(entityProgramacion As EntityTypeConfiguration(Of Programacion))
    entityProgramacion.
      ToTable("Informe").
      HasKey(Function(x) x.Id)
    entityProgramacion.
      Property(Function(p) p.Id).
        HasColumnName("Id_Informe")
    entityProgramacion.
      Property(Function(p) p.Hora).
        HasMaxLength(10)
  End Sub

  Private Shared Sub ConfigurarEntity(entityEjecucion As EntityTypeConfiguration(Of Ejecucion))
    entityEjecucion.
      ToTable("Ejecucion")
    entityEjecucion.
      Property(Function(p) p.Id).
        HasColumnName("Id_Ejecucion").
        HasColumnOrder(1)
    entityEjecucion.
      Property(Function(p) p.HoraProgramada).
        HasColumnName("Hora_Programada").
        HasMaxLength(10)
    entityEjecucion.
      Property(Function(p) p.HoraEjecucion).
        HasColumnName("Hora_Ejecucion")
    entityEjecucion.
      Property(Function(p) p.RutaFichero).
        HasColumnName("Ruta_Fichero")
  End Sub

  Private Shared Sub ConfigurarEntity(entityProyecto As EntityTypeConfiguration(Of Proyecto))
    entityProyecto.
      ToTable("Proyecto")
    entityProyecto.
      HasMany(Function(x) x.Permisos).
      WithRequired(Function(x) x.Proyecto).
      HasForeignKey(Function(x) x.IdProyecto).
      WillCascadeOnDelete()
    entityProyecto.
      Property(Function(p) p.Id).
        HasColumnName("Id_Proyecto").
        HasColumnOrder(1)
  End Sub

  Private Shared Sub ConfigurarEntity(entityPermisoUsuario As EntityTypeConfiguration(Of PermisoUsuario))
    entityPermisoUsuario.
      ToTable("Permiso_Usuario").
      HasKey(Function(x) New With {x.IdProyecto, x.NombreUsuario})
    entityPermisoUsuario.
      Property(Function(p) p.IdProyecto).
        HasColumnName("Id_Proyecto")
    entityPermisoUsuario.
      Property(Function(p) p.NombreUsuario).
        HasColumnName("Nombre_Usuario")
  End Sub
End Class
