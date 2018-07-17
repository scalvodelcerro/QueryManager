Public Class Programacion

    Public Sub New()
    End Sub

    Public Property Id As Integer
    Public Property Hora As String
    Public Property Lunes As Boolean
    Public Property Martes As Boolean
    Public Property Miercoles As Boolean
    Public Property Jueves As Boolean
    Public Property Viernes As Boolean
    Public Property Sabado As Boolean
    Public Property Domingo As Boolean
    Public Overridable Property Informe As Informe

    Public Function ProgramadoPara(horaEjecucion As Date) As Boolean
        Return ObtenerDiasProgramados().Contains(horaEjecucion.DayOfWeek) AndAlso
            Hora IsNot Nothing AndAlso
            ObtenerHoraProgramada() = horaEjecucion.Hour AndAlso
            ObtenerMinutoProgramado() = horaEjecucion.Minute
    End Function

    Private Function ObtenerDiasProgramados() As IEnumerable(Of DayOfWeek)
        Dim dias = New List(Of DayOfWeek)
        If Lunes Then dias.Add(DayOfWeek.Monday)
        If Martes Then dias.Add(DayOfWeek.Tuesday)
        If Miercoles Then dias.Add(DayOfWeek.Wednesday)
        If Jueves Then dias.Add(DayOfWeek.Thursday)
        If Viernes Then dias.Add(DayOfWeek.Friday)
        If Sabado Then dias.Add(DayOfWeek.Saturday)
        If Domingo Then dias.Add(DayOfWeek.Sunday)
        Return dias
    End Function

    Private Function ObtenerHoraProgramada() As Integer
        Return Integer.Parse(Hora.Split(":")(0))
    End Function

    Private Function ObtenerMinutoProgramado() As Integer
        Return Integer.Parse(Hora.Split(":")(1))
    End Function
End Class


