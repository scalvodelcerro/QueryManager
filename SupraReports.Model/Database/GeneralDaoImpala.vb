Imports System.Data.Odbc
Imports System.Configuration
Imports System.Reflection
Imports System.IO

Public Class GeneralDaoImpala
    Inherits GeneralDao

    Private Const SUPRA_RutaKeyTab = "C:\DATOS\RIR\RIR_Aux.dll"

    Protected Overrides Function ObtenerConexion() As Common.DbConnection
        'Guardar keytab en la ruta temporal
        Dim data = My.Resources.ueriskmi_sas
        Using w = New FileStream(SUPRA_RutaKeyTab, FileMode.OpenOrCreate, FileAccess.Write)
            w.Write(data, 0, data.Length)
        End Using

        Return ConnectionManager.GetConnection(ConnectionType.Impala)
    End Function

    Protected Overrides Function CrearComando(sql As String, conn As Common.DbConnection) As Common.DbCommand
        Return New OdbcCommand(sql, conn)
    End Function

    Protected Overrides Sub Dispose(disposing As Boolean)
        If IO.File.Exists(SUPRA_RutaKeyTab) Then
            File.Delete(SUPRA_RutaKeyTab)
        End If

        MyBase.Dispose(disposing)
    End Sub
End Class
