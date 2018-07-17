Imports System.Text.RegularExpressions

Public MustInherit Class ParametroDefecto

    Public MustOverride ReadOnly Property NombreParametro As String
    Public MustOverride ReadOnly Property Valor As String
    Public MustOverride Sub Modificar(modificador As Integer)

    Public Shared ReadOnly Property Todos As IEnumerable(Of String)
        Get
            Return New List(Of String) From {
                "HOY",
                "AYER",
                "AYER_HAB",
                "FMES",
                "FMES_HAB"
            }
        End Get
    End Property

    Public Shared Function ObtenerParametroDefecto(texto As String) As ParametroDefecto
        Dim pattern = "(\w+)([\+\-]\d+)?"
        Dim m = Regex.Match(texto, pattern)
        Dim nombre As String = m.Groups(1).Value
        Dim modificador As Integer = 0
        Integer.TryParse(m.Groups(2).Value, modificador)
        Dim parametro As ParametroDefecto
        Select Case nombre
            Case "HOY"
                parametro = New ParametroDefectoHoy()
            Case "AYER"
                parametro = New ParametroDefectoAyer()
            Case "AYER_HAB"
                parametro = New ParametroDefectoAyerHabil()
            Case "FMES"
                parametro = New ParametroDefectoFinMes()
            Case "FMES_HAB"
                parametro = New ParametroDefectoFinMesHabil()
            Case Else
                Return Nothing
        End Select
        If parametro IsNot Nothing Then
            parametro.Modificar(modificador)
        End If
        Return parametro
    End Function
End Class
