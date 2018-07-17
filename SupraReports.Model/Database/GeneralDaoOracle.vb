Imports System.Configuration
Imports System.Data.Common
Imports Oracle.ManagedDataAccess.Client

Public Class GeneralDaoOracle
    Inherits GeneralDao

    Protected Overrides Function ObtenerConexion() As DbConnection
        Return ConnectionManager.GetConnection(ConnectionType.Oracle)
    End Function

    Protected Overrides Function CrearComando(sql As String, conn As DbConnection) As DbCommand
        Return New OracleCommand(sql, conn)
    End Function
End Class
