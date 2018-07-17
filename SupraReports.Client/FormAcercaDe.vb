Imports System.Reflection

Public Class FormAcercaDe

    Private Sub FormAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim version As Version = Assembly.GetExecutingAssembly().GetName().Version
        LblVersion.Text = String.Format(LblVersion.Text, version.Major, version.Minor, version.Build, version.Revision)
    End Sub
End Class