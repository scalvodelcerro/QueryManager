Imports System.Text.RegularExpressions
Imports SupraReports.Model

Public Class UsarConsultaUserControl
  Private Const PatternParametro = "#(\w+)#"
  Public WriteOnly Property Consulta As Consulta
    Set(value As Consulta)
      _consulta = value
      TbNombre.Text = _consulta.Nombre
      TbSql.Text = _consulta.TextoSql
      PnlParametros.Controls.Clear()
      For Each p In _consulta.Parametros
        Dim control As ValorParametroUserControl = New ValorParametroUserControl()
        control.TbParametro.Text = p.Nombre
        control.TbValor.Text = p.Valor
        AddHandler control.CambiarValor, AddressOf OnCambiarValor
        AddHandler control.Seleccionar, AddressOf OnSeleccionar
        PnlParametros.Controls.Add(control)
      Next
    End Set
  End Property
  Private _consulta As Consulta

  Private Sub UsarConsultaUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComponerSqlResultado()
  End Sub

  Private Sub OnCambiarValor(sender As Object, e As ValorParametroUserControl.ValorParametroEventArgs)
    Dim parametro As Parametro = _consulta.Parametros.FirstOrDefault(Function(x) x.Nombre = e.Parametro)
    parametro.Valor = e.Valor
    Using repo = New InformeRepository(New SupraReportsContext())
      repo.Update(parametro)
      repo.Save()
    End Using
    ComponerSqlResultado()
    ResaltarParametro(e.Parametro, e.Valor)
  End Sub

  Private Sub OnSeleccionar(sender As Object, e As ValorParametroUserControl.ValorParametroEventArgs)
    ComponerSqlResultado()
    ResaltarParametro(e.Parametro, e.Valor)
  End Sub

  Private Sub ComponerSqlResultado()
    Dim textResult As String = _consulta.TextoSql.ToUpper()
    For Each p In _consulta.Parametros
      textResult = textResult.Replace(String.Format("#{0}#", p.Nombre), p.Valor)
    Next
    TbSqlResult.Text = textResult
  End Sub

  Private Sub ResaltarParametro(nombreParametro As String, valor As String)
    ResaltarPalabra(TbSql, String.Format("#{0}#", nombreParametro))
    ResaltarPalabra(TbSqlResult, valor)
  End Sub

  Private Sub ResaltarPalabra(rtb As RichTextBox, palabra As String)
    rtb.SelectAll()
    rtb.SelectionBackColor = SystemColors.Window

    If Not String.IsNullOrEmpty(palabra) And rtb.Text.ToUpper().Contains(palabra.ToUpper()) Then
      Dim index As Integer = rtb.Text.ToUpper().IndexOf(palabra.ToUpper(), index + 1)
      While index <> -1
        rtb.Select(index, palabra.Length)
        rtb.SelectionBackColor = Color.PaleGreen
        index = rtb.Text.ToUpper().IndexOf(palabra.ToUpper(), index + 1)
      End While
    End If
  End Sub
End Class
