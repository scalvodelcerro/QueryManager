Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration
Imports MySql.Data.EntityFramework

<DbConfigurationType(GetType(MySqlEFConfiguration))>
Public Class SupraReportsContext
  Inherits DbContext

  Public Property Informes As DbSet(Of Informe)
  Public Property Consultas As DbSet(Of Consulta)
  Public Property Parametros As DbSet(Of Parametro)
  Public Property Programaciones As DbSet(Of Programacion)
  Public Property Ejecuciones As DbSet(Of Ejecucion)

  Public Sub New()
    MyBase.New("name=SupraReports")
    Database.CreateIfNotExists()
  End Sub

  Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    MyBase.OnModelCreating(modelBuilder)
    ConfigurarEntity(modelBuilder.Entity(Of Informe)())
    ConfigurarEntity(modelBuilder.Entity(Of Consulta)())
    ConfigurarEntity(modelBuilder.Entity(Of Parametro)())
    ConfigurarEntity(modelBuilder.Entity(Of Programacion)())
    ConfigurarEntity(modelBuilder.Entity(Of Ejecucion)())
  End Sub

  Private Shared Sub ConfigurarEntity(entityInforme As EntityTypeConfiguration(Of Informe))
    entityInforme.
      ToTable("Informe").
      HasKey(Function(x) x.Id)
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
      Property(Function(p) p.Id).
        HasColumnName("Id_Informe").
        HasColumnOrder(1)
    entityInforme.
      Property(Function(p) p.Nombre).
        HasMaxLength(100)
    entityInforme.
      Property(Function(p) p.Usuario).
        HasMaxLength(50)
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
End Class
