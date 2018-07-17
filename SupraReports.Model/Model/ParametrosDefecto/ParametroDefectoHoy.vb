Public Class ParametroDefectoHoy
    Inherits ParametroDefectoFecha

    Public Sub New()
        fecha = Date.Today
    End Sub

    Public Overrides ReadOnly Property NombreParametro As String
        Get
            Return "HOY"
        End Get
    End Property

End Class
