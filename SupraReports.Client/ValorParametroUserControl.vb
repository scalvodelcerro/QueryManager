Imports SupraReports.Model

Public Class ValorParametroUserControl

    Protected Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(parametro As Parametro)
        Me.New()
        Me.Parametro = parametro
        LblNombre.DataBindings.Add("Text", parametro, "Nombre")
        TbValor.DataBindings.Add("Text", parametro, "Valor")
    End Sub

    Public Property Parametro As Parametro

    Private Sub TbValor_TextChanged(sender As Object, e As EventArgs) Handles TbValor.TextChanged
        If Parametro IsNot Nothing Then
            Parametro.Consulta.Informe.ActualizarValorParametro(Parametro.Nombre, TbValor.Text)
        End If
    End Sub
End Class
