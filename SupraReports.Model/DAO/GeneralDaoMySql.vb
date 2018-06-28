Imports System.Configuration
Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class GeneralDaoMySql
  Inherits GeneralDao

  Protected Overrides Function ObtenerConexion() As DbConnection
    Dim connectionString As String = ConfigurationManager.ConnectionStrings(My.Settings.SupraReportsMySqlConnectionStringName).ConnectionString
    Return New MySqlConnection(connectionString)
  End Function

  Protected Overrides Function CrearComando(sql As String, conn As DbConnection) As DbCommand
    Return New MySqlCommand(sql, conn)
  End Function
End Class
