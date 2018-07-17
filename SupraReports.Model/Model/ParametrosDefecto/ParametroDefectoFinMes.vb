Public Class ParametroDefectoFinMes
    Inherits ParametroDefectoFecha

    Public Sub New()
        fecha = New Date(Today.Year, Today.Month, 1).AddDays(-1)
    End Sub

    Public Overrides ReadOnly Property NombreParametro As String
        Get
            Return "FMES"
        End Get
    End Property
End Class
