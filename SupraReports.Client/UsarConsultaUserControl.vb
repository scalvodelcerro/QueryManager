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
        PnlParametros.Controls.Add(control)
      Next
    End Set
  End Property
  Private _consulta As Consulta


End Class
