Imports SupraReports.Model

Public Class Programacion
  Inherits EntidadConEstado
  'Private _id As Integer
  Private _hora As String
  Private _lunes As Boolean
  Private _martes As Boolean
  Private _miercoles As Boolean
  Private _jueves As Boolean
  Private _viernes As Boolean
  Private _sabado As Boolean
  Private _domingo As Boolean
  Private _idInforme As Integer
  Private _informe As Informe

  Private Sub New()
  End Sub

  'Public Property Id As Integer
  '  Get
  '    Return _id
  '  End Get
  '  Private Set(value As Integer)
  '    _id = value
  '  End Set
  'End Property

  Public Property Hora As String
    Get
      Return _hora
    End Get
    Private Set(value As String)
      _hora = value
    End Set
  End Property

  Public Property Lunes As Boolean
    Get
      Return _lunes
    End Get
    Private Set(value As Boolean)
      _lunes = value
    End Set
  End Property

  Public Property Martes As Boolean
    Get
      Return _martes
    End Get
    Private Set(value As Boolean)
      _martes = value
    End Set
  End Property

  Public Property Miercoles As Boolean
    Get
      Return _miercoles
    End Get
    Private Set(value As Boolean)
      _miercoles = value
    End Set
  End Property

  Public Property Jueves As Boolean
    Get
      Return _jueves
    End Get
    Private Set(value As Boolean)
      _jueves = value
    End Set
  End Property

  Public Property Viernes As Boolean
    Get
      Return _viernes
    End Get
    Private Set(value As Boolean)
      _viernes = value
    End Set
  End Property

  Public Property Sabado As Boolean
    Get
      Return _sabado
    End Get
    Private Set(value As Boolean)
      _sabado = value
    End Set
  End Property

  Public Property Domingo As Boolean
    Get
      Return _domingo
    End Get
    Private Set(value As Boolean)
      _domingo = value
    End Set
  End Property

  Public Property IdInforme As Integer
    Get
      Return _idInforme
    End Get
    Private Set(value As Integer)
      _idInforme = value
    End Set
  End Property

  Public Overridable Property Informe As Informe
    Get
      Return _informe
    End Get
    Set(value As Informe)
      _informe = value
    End Set
  End Property

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
      programacion.IdInforme = informe.Id
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
      Return Me.programacion
    End Function
  End Class
End Class


