Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class GeneralDaoMySql
    Inherits GeneralDao

    Protected Overrides Function ObtenerConexion() As DbConnection
    Return GetConnection(ConnectionType.MySql)
  End Function

    Protected Overrides Function CrearComando(sql As String, conn As DbConnection) As DbCommand
        Return New MySqlCommand(sql, conn)
    End Function
End Class
