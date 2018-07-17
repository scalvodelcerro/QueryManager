Imports System.Data.Entity
Imports MySql.Data.Entity

<DbConfigurationType(GetType(MySqlEFConfiguration))>
Public Class SupraReportsContextMySql
  Inherits SupraReportsContext

  Public Sub New()
        MyBase.New(ConnectionManager.GetConnection(ConnectionType.MySql))
  End Sub
End Class
