Public Class ValorParametroDefectoUserControl
    Inherits ValorParametroUserControl

    Public Sub New(nombreParametro As String, valorParametro As String)
        MyBase.New()
        LblNombre.Text = nombreParametro
        TbValor.Text = valorParametro
        TbValor.ReadOnly = True
        TbValor.BackColor = SystemColors.Control
    End Sub

End Class
