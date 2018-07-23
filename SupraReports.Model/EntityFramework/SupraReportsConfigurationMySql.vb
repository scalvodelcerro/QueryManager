Imports System.Data.Entity
Imports MySql.Data.Entity
Imports MySql.Data.MySqlClient

Public Class SupraReportsConfigurationMySql
  Inherits DbConfiguration

  Public Sub New()
    AddDependencyResolver(New MySqlDependencyResolver())

    SetProviderFactory(MySqlProviderInvariantName.ProviderName, New MySqlClientFactory()) 'MySql.Data.MySqlClient
    SetProviderServices(MySqlProviderInvariantName.ProviderName, New MySqlProviderServices())
    SetDefaultConnectionFactory(New MySqlConnectionFactory())
    SetMigrationSqlGenerator(MySqlProviderInvariantName.ProviderName, Function() New MySqlMigrationSqlGenerator())
    SetProviderFactoryResolver(New MySqlProviderFactoryResolver())
    SetManifestTokenResolver(New MySqlManifestTokenResolver())
    SetHistoryContext(MySqlProviderInvariantName.ProviderName, Function(existingConnection, defaultSchema) New SupraReportsHistoryContextMySql(existingConnection, defaultSchema))

    SetExecutionStrategy(MySqlProviderInvariantName.ProviderName, Function() New SupraReportsExecutionStrategy(3, TimeSpan.FromMilliseconds(2000)))
  End Sub

End Class
