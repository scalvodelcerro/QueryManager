Imports System.Data.Entity

'<DbConfigurationType(GetType(SupraReportsConfigurationOracle))>
Public Class SupraReportsContextOracle
    Inherits SupraReportsContext

    Public Sub New()
        MyBase.New(ConnectionManager.GetConnection(ConnectionType.Oracle))
    End Sub

End Class
