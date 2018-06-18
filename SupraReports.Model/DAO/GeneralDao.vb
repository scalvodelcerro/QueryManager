Imports System.Configuration
Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class GeneralDao
  Implements IDisposable

  Private conn As DbConnection

  Public Sub New(conn As DbConnection)
    Me.conn = conn
  End Sub

  Public Function EjecutarSelect(sql As String) As IDataReader
    Try
      If conn.State = ConnectionState.Closed Then
        conn.Open()
      End If
      Return New MySqlCommand(sql, conn).ExecuteReader()
    Catch ex As Exception
      Return Nothing
    End Try
  End Function

  Public Shared Function CrearConexionMySql() As DbConnection
    Dim connectionString As String = ConfigurationManager.ConnectionStrings(My.Settings.SupraReportsConnectionStringName).ConnectionString
    Return New MySqlConnection(connectionString)
  End Function

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
