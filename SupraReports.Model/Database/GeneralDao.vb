Imports System.Data.Common
Imports SupraReports.Model.SupraReportsContext

Public MustInherit Class GeneralDao
    Implements IDisposable

    Public Shared Function Crear(databaseType As DatabaseTypes) As GeneralDao
        Select Case databaseType
            Case DatabaseTypes.MySql
                Return New GeneralDaoMySql()
            Case DatabaseTypes.Oracle
                Return New GeneralDaoOracle()
            Case DatabaseTypes.Impala
                Return New GeneralDaoImpala()
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function EjecutarSelect(sql As String) As DataTable
        Dim dataTable = New DataTable()
        Using conn = ObtenerConexion()
            conn.Open()
            dataTable.Load(CrearComando(sql, conn).ExecuteReader())
        End Using
        Return dataTable
    End Function

    Public Function ComprobarConexion()
        Using conn = ObtenerConexion()
            Try
                conn.Open()
            Catch ex As Exception
                Return False
            End Try
        End Using
        Return True
    End Function

    Protected MustOverride Function ObtenerConexion() As DbConnection
    Protected MustOverride Function CrearComando(sql As String, conn As DbConnection) As DbCommand

#Region "IDisposable Support"

    Protected Overridable Sub Dispose(disposing As Boolean)
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub
#End Region
End Class
