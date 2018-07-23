Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.EntityFramework

Public Class SupraReportsConfigurationOracle
  Inherits DbConfiguration

  Public Sub New()
    SetProviderFactory("Oracle.ManagedDataAccess.Client", New OracleClientFactory())
    SetProviderServices("Oracle.ManagedDataAccess.Client", EFOracleProviderServices.Instance)
    SetDefaultConnectionFactory(New OracleConnectionFactory())
    SetExecutionStrategy("Oracle.ManagedDataAccess.Client", Function() New SupraReportsExecutionStrategy(3, TimeSpan.FromMilliseconds(2000)))
  End Sub

End Class

Public Class SupraReportsExecutionStrategy
  Inherits DbExecutionStrategy

  Public Sub New(maxRetryCount As Integer, maxDelay As TimeSpan)
    MyBase.New(maxRetryCount, maxDelay)
  End Sub

  Protected Overrides Function ShouldRetryOn(exception As Exception) As Boolean
    Return True
  End Function
End Class
