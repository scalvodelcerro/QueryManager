Public Class ParametroDefectoAyer
    Inherits ParametroDefectoFecha

    Public Sub New()
        fecha = DateTime.Today.AddDays(-1)
    End Sub

    Public Overrides ReadOnly Property NombreParametro As String
        Get
            Return "AYER"
        End Get
    End Property

End Class
