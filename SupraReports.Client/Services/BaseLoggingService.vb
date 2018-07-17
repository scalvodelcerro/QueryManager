Imports SupraReports.Model
Imports RMIS_Lib

Public Class BaseLoggingService
    Implements ILoggingService

    Private base As Base
    Public Sub New(base As Base)
        Me.base = base
    End Sub

    Public Sub Log(texto As String) Implements ILoggingService.Log
        base.RegistrarLog(My.Resources.Login_App, texto.Take(70).ToArray())
    End Sub
End Class
