Public MustInherit Class ParametroDefectoFecha
    Inherits ParametroDefecto

    Protected Const formatoFecha As String = "yyyy-MM-dd HH:mm:ss"

    Protected fecha As Date

    Public Overrides ReadOnly Property Valor As String
        Get
            Return fecha
        End Get
    End Property

    Public Overrides Sub Modificar(modificador As Integer)
        fecha = fecha.AddDays(modificador)
    End Sub

End Class
