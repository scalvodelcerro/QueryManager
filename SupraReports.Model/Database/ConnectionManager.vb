Imports System.Data.Common
Imports Oracle.ManagedDataAccess.Client
Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Module ConnectionManager
  Public Enum ConnectionType
    Oracle
    Impala
    MySql
  End Enum

  Function GetConnection(type As ConnectionType) As DbConnection
    Select Case type
      Case ConnectionType.Oracle
        Return New OracleConnection(RMIS_ADMON_DES)
      Case ConnectionType.Impala
        Return New OdbcConnection(SUPRA_IMPALA_DES)
      Case ConnectionType.MySql
        Return New MySqlConnection(DEV_MYSQL)
      Case Else
        Return Nothing
    End Select
  End Function

End Module

Module ConnectionStrings
  Public RMIS_ADMON_DES As String = "Data Source=DSIAD;User Id=RMIS_ADMON;Password=Pa_65t9u;Connection Timeout = 0"
  Public RMIS_ADMON_PRO As String = "Data Source=SIRMPRO;User Id=n80730;Password=Nomi730+;Connection Timeout = 0"
  Public SUPRA_IMPALA_DES As String = "Driver=Cloudera ODBC Driver for Impala;Host=corporacionimpala.aacc.gs.corp;Port=21050;AuthMech=1;KrbRealm=IDMPRO.UNIX.AACC.CORP;KrbFQDN=corporacionimpala.aacc.gs.corp;KrbServiceName=impala;"
  Public DEV_MYSQL As String = "server=localhost;port=3306;database=supra_reports;uid=root;password=;SslMode=none"
End Module


