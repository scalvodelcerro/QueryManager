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
    Parametros = New List(Of Parametro)()
  End Sub

  Public Property Id As Integer
  Public Property Nombre As String
  Public Property TextoSql As String
  Public Property Informe As Informe
  Public Overridable Property Parametros As ICollection(Of Parametro)

  Public Sub AnadirParametro(nombreParametro As String, valorParametro As String)
    Parametros.Add(Parametro.Crear(nombreParametro, valorParametro, Me))
  End Sub

  Public Function ComponerSqlResultado() As String
    Dim textResult As String = TextoSql.ToUpper()
    For Each p In Parametros
      textResult = textResult.Replace(String.Format("#{0}#", p.Nombre), p.Valor)
    Next
    For Each p In Parametro.ParametroDefecto.Todos
      textResult = textResult.Replace(String.Format("#{0}#", p.NombreParametro), p.Valor)
    Next
    Return textResult
  End Function

End Class