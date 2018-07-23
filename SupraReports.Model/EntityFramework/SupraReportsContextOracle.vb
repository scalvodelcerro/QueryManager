Imports System.Data.Entity

<DbConfigurationType(GetType(SupraReportsConfigurationOracle))>
Public Class SupraReportsContextOracle
    Inherits SupraReportsContext

  Public Sub New()
    MyBase.New(ConnectionManager.GetConnection(ConnectionType.Oracle))
    Database.SetInitializer(New NullDatabaseInitializer(Of SupraReportsContextOracle)())
  End Sub

  Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
    modelBuilder.HasDefaultSchema(Naming.ESQUEMA_RMIS_ADMON)
    MyBase.OnModelCreating(modelBuilder)
  End Sub

End Class
