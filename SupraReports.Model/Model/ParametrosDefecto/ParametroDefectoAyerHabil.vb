Public Class ParametroDefectoAyerHabil
    Inherits ParametroDefectoAyer

    Private diasInhabiles As DayOfWeek() = {DayOfWeek.Saturday, DayOfWeek.Sunday}

    Public Sub New()
        MyBase.New()

        While diasInhabiles.Contains(fecha.DayOfWeek)
            fecha = fecha.AddDays(-1)
        End While
    End Sub

    Public Overrides ReadOnly Property NombreParametro As String
        Get
            Return "AYER_HAB"
        End Get
    End Property
End Class
