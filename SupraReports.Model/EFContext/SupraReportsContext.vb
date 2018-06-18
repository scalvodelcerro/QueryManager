Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports MySql.Data.EntityFramework

<DbConfigurationType(GetType(MySqlEFConfiguration))>
Public Class SupraReportsContext
  Inherits DbContext

  Public Property Informes As DbSet(Of Informe)

  Public Sub New()
    MyBase.New("name=SupraReports")
    Database.CreateIfNotExists()
  End Sub

  Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    MyBase.OnModelCreating(modelBuilder)
    modelBuilder.Types(Of EntidadConEstado)().Configure(Function(c) c.Ignore(Function(p) p.Estado))
    ConfigurarEntity(modelBuilder.Entity(Of Informe)())
    ConfigurarEntity(modelBuilder.Entity(Of Consulta)())
    ConfigurarEntity(modelBuilder.Entity(Of Parametro)())
  End Sub

  Private Shared Sub ConfigurarEntity(entityInforme As ModelConfiguration.EntityTypeConfiguration(Of Informe))
    entityInforme.
      ToTable("Informe").
      HasMany(Informe.Mappings.Consultas).
      WithRequired(Function(x) x.Informe).
      HasForeignKey(Function(x) x.IdInforme).
      WillCascadeOnDelete()
    entityInforme.
      Property(Function(p) p.Id).
      HasColumnName("Id_Informe")
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
          HasColumnName("Id_Consulta")
    entityConsulta.
      Property(Function(p) p.IdInforme).
          HasColumnName("Id_Informe")
    entityConsulta.
      Property(Function(p) p.TextoSql).
          HasColumnName("Texto_Sql")
  End Sub

  Private Shared Sub ConfigurarEntity(entityParametro As ModelConfiguration.EntityTypeConfiguration(Of Parametro))
    entityParametro.
          ToTable("Parametro")
    entityParametro.
      Property(Function(p) p.Id).
          HasColumnName("Id_Parametro")
    entityParametro.
      Property(Function(p) p.IdConsulta).
          HasColumnName("Id_Consulta")
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
