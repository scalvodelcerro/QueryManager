Public Class Programacion

  Private Sub New()
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
  Public Property Informe As Informe

  Public Function HayAlgunDiaProgramado() As Boolean
    Return Lunes OrElse Martes OrElse Miercoles OrElse Jueves OrElse Viernes OrElse Sabado OrElse Domingo
  End Function

  Public Function ObtenerDiasProgramados() As IEnumerable(Of DayOfWeek)
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

  Public Function ObtenerHoraProgramada() As Integer
    Return Integer.Parse(Hora.Split(":")(0))
  End Function

  Public Function ObtenerMinutoProgramado() As Integer
    Return Integer.Parse(Hora.Split(":")(1))
  End Function

  Public Class ProgramacionBuilder
    Private programacion As Programacion = New Programacion()

    Public Function ParaInforme(informe As Informe) As ProgramacionBuilder
      programacion.Informe = informe
      Return Me
    End Function

    Public Function ParaHora(hora As String) As ProgramacionBuilder
      programacion.Hora = hora
      Return Me
    End Function

    Public Function ParaDia(dia As DayOfWeek) As ProgramacionBuilder
      Select Case dia
        Case DayOfWeek.Monday
          programacion.Lunes = True
        Case DayOfWeek.Tuesday
          programacion.Martes = True
        Case DayOfWeek.Wednesday
          programacion.Miercoles = True
        Case DayOfWeek.Thursday
          programacion.Jueves = True
        Case DayOfWeek.Friday
          programacion.Viernes = True
        Case DayOfWeek.Saturday
          programacion.Sabado = True
        Case DayOfWeek.Sunday
          programacion.Domingo = True
      End Select
      Return Me
    End Function

    Public Function Build() As Programacion
      Return programacion
    End Function
  End Class
End Class


