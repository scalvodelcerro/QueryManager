Imports System.Text.RegularExpressions
Imports SupraReports.Model

Public Class EditarConsultaUserControl
  Private Const PatternParametro = "#(\w+)#"
  Public WriteOnly Property Consulta As Consulta
    Set(value As Consulta)
      _consulta = value
      TbNombre.Text = _consulta.Nombre
      TbSql.Text = _consulta.TextoSql
    End Set
  End Property
  Private _consulta As Consulta

  Private Sub TbNombre_TextChanged(sender As Object, e As EventArgs) Handles TbNombre.TextChanged
    _consulta.Nombre = TbNombre.Text
  End Sub

  Private Sub TbSql_TextChanged(sender As Object, e As EventArgs) Handles TbSql.TextChanged
    _consulta.TextoSql = TbSql.Text
    Dim parametros = Regex.Matches(_consulta.TextoSql, PatternParametro).Cast(Of Match).Select(Function(x) x.Groups(1).Value.ToUpper()).Distinct()
    LbParametros.Items.Clear()
    For Each p In parametros
      LbParametros.Items.Add(p)
    Next
  End Sub

  Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
    Using repo = New InformeRepository(New SupraReportsContext())
      repo.Delete(_consulta)
      repo.Save()
    End Using
    Dispose()
  End Sub
End Class
