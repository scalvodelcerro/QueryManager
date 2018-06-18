Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration
Imports MySql.Data.EntityFramework

<DbConfigurationType(GetType(MySqlEFConfiguration))>
Public NotInheritable Class SupraReportsContext
  Inherits DbContext

  Public Shared ReadOnly Property Instance As SupraReportsContext
    Get
      If _instance Is Nothing Then _instance = New SupraReportsContext()
      Return _instance
    End Get
  End Property
  Private Shared _instance As SupraReportsContext

  Public Property Informes As DbSet(Of Informe)
  Public Property Programaciones As DbSet(Of Programacion)

  Private Sub New()
    MyBase.New("name=SupraReports")
    Database.CreateIfNotExists()
  End Sub

  Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    MyBase.OnModelCreating(modelBuilder)
    modelBuilder.Types(Of EntidadConEstado)().Configure(Function(c) c.Ignore(Function(p) p.Estado))
    ConfigurarEntity(modelBuilder.Entity(Of Informe)())
    ConfigurarEntity(modelBuilder.Entity(Of Consulta)())
    ConfigurarEntity(modelBuilder.Entity(Of Parametro)())
    ConfigurarEntity(modelBuilder.Entity(Of Programacion)())
  End Sub

  Private Shared Sub ConfigurarEntity(entityInforme As ModelConfiguration.EntityTypeConfiguration(Of Informe))
    entityInforme.
      ToTable("Informe").
      HasMany(Informe.Mappings.Consultas).
      WithRequired(Function(x) x.Informe).
      HasForeignKey(Function(x) x.IdInforme).
      WillCascadeOnDelete()
    entityInforme.
      HasOptional(Function(x) x.Programacion).
      WithRequired(Function(x) x.Informe).
      WillCascadeOnDelete()
    entityInforme.
      Property(Function(p) p.Id).
        HasColumnName("Id_Informe").
        HasColumnOrder(1)
  End Sub

  Private Shared Sub ConfigurarEntity(entityConsulta As ModelConfiguration.EntityTypeConfiguration(Of Consulta))
    entityConsulta.
      ToTable("Consulta").
      HasMany(Consulta.Mappings.Parametros).
      WithRequired(Function(x) x.Consulta).
      HasForeignKey(Function(x) x.IdConsulta).
      WillCascadeOnDelete()
    entityConsulta.
      Property(Function(p) p.Id).
        HasColumnName("Id_Consulta").
        HasColumnOrder(1)
    entityConsulta.
      Property(Function(p) p.IdInforme).
        HasColumnName("Id_Informe").
        HasColumnOrder(2)
    entityConsulta.
      Property(Function(p) p.TextoSql).
        HasColumnName("Texto_Sql")
  End Sub

  Private Shared Sub ConfigurarEntity(entityParametro As ModelConfiguration.EntityTypeConfiguration(Of Parametro))
    entityParametro.
      ToTable("Parametro")
    entityParametro.
      Property(Function(p) p.Id).
        HasColumnName("Id_Parametro").
        HasColumnOrder(1)
    entityParametro.
      Property(Function(p) p.IdConsulta).
        HasColumnName("Id_Consulta").
        HasColumnOrder(2)
  End Sub

  Private Sub ConfigurarEntity(entityProgramacion As EntityTypeConfiguration(Of Programacion))
    entityProgramacion.
      ToTable("Programacion").
      HasKey(Function(x) x.IdInforme)
    'entityProgramacion.
    '  Property(Function(p) p.Id).
    '    HasColumnName("Id_Programacion").
    '    HasColumnOrder(1)
    entityProgramacion.
      Property(Function(p) p.IdInforme).
        HasColumnName("Id_Informe").
        HasColumnOrder(2)
  End Sub

  Public Sub FixState()
    For Each entry As DbEntityEntry(Of EntidadConEstado) In ChangeTracker.Entries(Of EntidadConEstado)()
      Dim entidadConEstado As EntidadConEstado = entry.Entity
      entry.State = ConvertState(entidadConEstado.Estado)
    Next entry
  End Sub

  Public Sub LimpiarEstadoEntidades()
    For Each entry As DbEntityEntry(Of EntidadConEstado) In ChangeTracker.Entries(Of EntidadConEstado)()
      Dim entidadConEstado As EntidadConEstado = entry.Entity
      entidadConEstado.MarcarComoSinCambios()
    Next entry
  End Sub

  Public Shared Function ConvertState(ByVal estado As EstadoEntidad) As EntityState
    Select Case estado
      Case EstadoEntidad.Nuevo
        Return EntityState.Added
      Case EstadoEntidad.Modificado
        Return EntityState.Modified
      Case EstadoEntidad.Eliminado
        Return EntityState.Deleted
      Case Else
        Return EntityState.Unchanged
    End Select
  End Function

End Class
