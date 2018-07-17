Imports System.Text.RegularExpressions

Public Class Consulta

    Public Shared Function Crear(nombre As String, textoSql As String) As Consulta
        Dim consulta As Consulta = New Consulta(nombre, textoSql)
        Return consulta
    End Function

    Public Shared Function Copiar(consulta As Consulta) As Consulta
        Dim copiaConsulta As Consulta = Crear(consulta.Nombre, consulta.TextoSql)
        For Each p In consulta.Parametros
            copiaConsulta.AnadirParametro(p.Nombre, p.Valor)
        Next
        Return copiaConsulta
    End Function

    Protected Sub New()
    End Sub

    Private Sub New(nombre As String, textoSql As String)
        Me.Nombre = nombre
        Me.TextoSql = textoSql
        Habilitada = True
        Parametros = New List(Of Parametro)()
    End Sub

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property TextoSql As String
    Public Property Habilitada As Boolean
    Public Property Informe As Informe
    Public Overridable Property Parametros As ICollection(Of Parametro)

    Public Sub AnadirParametro(nombreParametro As String, valorParametro As String)
        Parametros.Add(Parametro.Crear(nombreParametro, valorParametro, Me))
    End Sub

    Public Function ComponerSqlResultado() As String
        If TextoSql Is Nothing Then Return String.Empty
        Dim textResult As String = PreprocesarParametrosDefecto(TextoSql.ToUpper())
        For Each p In Parametros
            textResult = textResult.Replace(String.Format("#{0}#", p.Nombre), p.Valor)
        Next
        Return textResult
    End Function

    Private Function PreprocesarParametrosDefecto(textoSql As String) As String
        Dim pattern = "#@([^#]*)#"
        Dim texto = textoSql
        For Each m In Regex.Matches(textoSql, pattern).Cast(Of Match)()
            texto = texto.Replace(m.Groups(0).Value, ParametroDefecto.ObtenerParametroDefecto(m.Groups(1).Value).Valor)
        Next
        Return texto
    End Function

End Class