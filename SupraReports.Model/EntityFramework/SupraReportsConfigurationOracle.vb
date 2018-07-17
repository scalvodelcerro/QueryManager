Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.EntityFramework

'Public Class SupraReportsConfigurationOracle
'    Inherits DbConfiguration

'    Public Sub New()
'        'SetDefaultConnectionFactory(New OracleConnectionFactory())
'        SetProviderServices("Oracle.ManagedDataAccess.Client", EFOracleProviderServices.Instance)
'        SetProviderFactory("Oracle.ManagedDataAccess.Client", New OracleClientFactory())
'        SetExecutionStrategy("Oracle.ManagedDataAccess.Client", Function() New SupraReportsExecutionStrategy())
'    End Sub

'End Class

Public Class SupraReportsExecutionStrategy
    Inherits DbExecutionStrategy

    Protected Overrides Function ShouldRetryOn(exception As Exception) As Boolean
        Return True
    End Function
End Class
