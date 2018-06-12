Imports System.Text.RegularExpressions
Imports SupraReports.Model

Public Class UsarConsultaUserControl
  Private Const PatternParametro = "#(\w+)#"
  Public WriteOnly Property Consulta As Consulta
    Set(value As Consulta)
      _consulta = value
      TbNombre.Text = _consulta.Nombre
      TbSql.Text = _consulta.TextoSql
      Dim parametros = Regex.Matches(_consulta.TextoSql, PatternParametro).Cast(Of Match).Select(Function(x) x.Groups(1).Value.ToUpper()).Distinct()
      PnlParametros.Controls.Clear()
      For Each p In parametros
        Dim control As ValorParametroUserControl = New ValorParametroUserControl()
        control.TbParametro.Text = p
        AddHandler control.CambiarValor, AddressOf OnCambiarValor
        PnlParametros.Controls.Add(control)
      Next
    End Set
  End Property
  Private _consulta As Consulta

  Private Sub OnCambiarValor(sender As Object, e As ValorParametroUserControl.CambiarValorEventArgs)
    Dim parametro As Parametro = _consulta.Parametros.FirstOrDefault(Function(x) x.Nombre = e.Parametro)
    If parametro Is Nothing Then
      parametro = New Parametro(e.Parametro, e.Valor, _consulta)
      Using repo = New InformeRepository(New SupraReportsContext())
        repo.Create(parametro)
      End Using
    Else
      parametro.Valor = e.Valor
      Using repo = New InformeRepository(New SupraReportsContext())
        repo.Update(parametro)
      End Using
    End If

    Dim textResult As String = _consulta.TextoSql.ToUpper()
    For Each p In _consulta.Parametros
      textResult = textResult.Replace(String.Format("#{0}#", p.Nombre), p.Valor)
    Next
    TbSqlResult.Text = textResult
  End Sub

End Class
