Imports System.Configuration
Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Oracle.ManagedDataAccess.Client
Imports SupraReports.Model.SupraReportsContext

Public MustInherit Class GeneralDao
  Implements IDisposable

  Private conn As DbConnection

  Public Shared Function Crear(databaseType As DatabaseTypes) As GeneralDao
    Select Case databaseType
      Case DatabaseTypes.MySql
        Return New GeneralDaoMySql()
      Case DatabaseTypes.Oracle
        Return New GeneralDaoOracle()
      Case Else
        Return Nothing
    End Select
  End Function

  Protected Sub New()
    conn = ObtenerConexion()
  End Sub

  Public Function EjecutarSelect(sql As String) As DataTable
    If conn.State = ConnectionState.Closed Then
      conn.Open()
    End If
    Dim dataTable = New DataTable()
    Dim o As OracleCommand = New OracleCommand()
    dataTable.Load(CrearComando(sql, conn).ExecuteReader())
    Return dataTable
  End Function

  Public Shared Function CrearConexionMySql() As DbConnection
    Dim connectionString As String = ConfigurationManager.ConnectionStrings(My.Settings.SupraReportsMySqlConnectionStringName).ConnectionString
    Return New MySqlConnection(connectionString)
  End Function

  Protected MustOverride Function ObtenerConexion() As DbConnection
  Protected MustOverride Function CrearComando(sql As String, conn As DbConnection) As DbCommand

#Region "IDisposable Support"
  Private disposedValue As Boolean

  Protected Overridable Sub Dispose(disposing As Boolean)
    If Not disposedValue Then
      If disposing Then
        conn.Dispose()
      End If
    End If
    disposedValue = True
  End Sub

  Public Sub Dispose() Implements IDisposable.Dispose
    Dispose(True)
  End Sub
#End Region
End Class
