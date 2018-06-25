Imports System.Collections.ObjectModel
Imports System.Text.RegularExpressions
Imports SupraReports.Model

Public Class EditarConsultaUserControl
  Private Const PatternParametro As String = "#(\w+)#"
  Private colorResaltarTexto As Color = Color.PaleGreen
  Private db As SupraReportsContext

  Public Sub New(db As SupraReportsContext, consulta As Consulta)
    InitializeComponent()
    Me.db = db
    Me.Consulta = consulta
    TbSql.Sugerencias = New Collection(Of String)(Parametro.ParametroDefecto.Todos.
                                                  Select(Function(x) x.NombreParametro).
                                                  OrderBy(Function(x) x).
                                                  ToList())
  End Sub

  Public WriteOnly Property Consulta As Consulta
    Set(value As Consulta)
      _consulta = value
      TbNombre.Text = _consulta.Nombre
      TbSql.Text = _consulta.TextoSql
      CargarParametros()
    End Set
  End Property
  Private _consulta As Consulta

  Private Sub EditarConsultaUserControl_Load(sender As Object, e As EventArgs)
    TbSqlResult.Text = String.Empty
    TbSqlResult.AppendText(_consulta.ComponerSqlResultado())
  End Sub

  Private Sub TbNombre_TextChanged(sender As Object, e As EventArgs)
    _consulta.Nombre = TbNombre.Text
  End Sub

  Private Sub TbSql_TextChanged(sender As Object, e As EventArgs) Handles TbSql.TextChanged
    If TbSql.Focused Then
      _consulta.TextoSql = TbSql.Text
      Dim nombresParametros As IEnumerable(Of String) = Regex.Matches(_consulta.TextoSql, PatternParametro).Cast(Of Match).Select(Function(x) x.Groups(1).Value.ToUpper()).Distinct()
      Dim eliminados As IEnumerable(Of Parametro) = _consulta.Parametros.Where(Function(x) Not nombresParametros.Contains(x.Nombre)).ToList()
      For Each p In eliminados
        db.Parametros.Remove(p)
      Next
      For Each nombreParametro In nombresParametros.Except(_consulta.Parametros.Select(Function(x) x.Nombre))
        If Parametro.ParametroDefecto.Lookup(nombreParametro) Is Nothing Then
          _consulta.AnadirParametro(nombreParametro, String.Empty)
        End If
      Next
      CargarParametros()
      TbSqlResult.Text = String.Empty
      TbSqlResult.AppendText(_consulta.ComponerSqlResultado())
    End If
  End Sub

  Private Sub BtnEliminarConsulta_Click(sender As Object, e As EventArgs) Handles BtnEliminarConsulta.Click
    db.Consultas.Remove(_consulta)
    Dispose()
  End Sub

  Private Sub OnCambiarValorParametro(sender As Object, e As EventArgs)
    Dim control = CType(CType(sender, TextBox).Parent, ValorParametroUserControl)
    Dim parametro As Parametro = _consulta.Parametros.FirstOrDefault(Function(x) x.Nombre = control.NombreParametro)
    parametro.Valor = control.Valor
    TbSqlResult.Text = String.Empty
    TbSqlResult.AppendText(_consulta.ComponerSqlResultado())
    ResaltarParametro(control.NombreParametro, control.Valor, colorResaltarTexto)
  End Sub

  Private Sub OnSeleccionarParametro(sender As Object, e As EventArgs)
    Dim control = CType(CType(sender, TextBox).Parent, ValorParametroUserControl)
    ResaltarParametro(control.NombreParametro, control.Valor, colorResaltarTexto)
  End Sub

  Private Sub OnDeseleccionarParametro(sender As Object, e As EventArgs)
    LimpiarResaltado(TbSql)
    LimpiarResaltado(TbSqlResult)
  End Sub

  Private Sub CargarParametros()
    PnlParametros.Controls.Clear()
    For Each p In _consulta.Parametros.OrderBy(Function(x) x.Nombre)
      Dim control As ValorParametroUserControl = New ValorParametroUserControl(p.Nombre, p.Valor)
      AddHandler control.TbValor.GotFocus, AddressOf OnSeleccionarParametro
      AddHandler control.TbValor.LostFocus, AddressOf OnDeseleccionarParametro
      AddHandler control.TbValor.TextChanged, AddressOf OnCambiarValorParametro
      PnlParametros.Controls.Add(control)
    Next
    For Each p In Parametro.ParametroDefecto.Todos
      If _consulta.TextoSql.ToUpper().Contains(String.Format("#{0}#", p.NombreParametro.ToUpper)) Then
        Dim control As ValorParametroUserControl =
          New ValorParametroUserControl(p.NombreParametro, p.Valor)
        control.TbValor.ReadOnly = True
        AddHandler control.TbValor.GotFocus, AddressOf OnSeleccionarParametro
        AddHandler control.TbValor.LostFocus, AddressOf OnDeseleccionarParametro
        AddHandler control.TbValor.TextChanged, AddressOf OnCambiarValorParametro
        PnlParametros.Controls.Add(control)
      End If
    Next
  End Sub

  Private Sub LimpiarResaltado(rtb As RichTextBox)
    rtb.Text = rtb.Text.ToString()
  End Sub

  Private Sub ResaltarParametro(nombreParametro As String, valor As String, color As Color)
    LimpiarResaltado(TbSql)
    ResaltarPalabra(TbSql, String.Format("#{0}#", nombreParametro), color)
    LimpiarResaltado(TbSqlResult)
    ResaltarPalabra(TbSqlResult, valor, color)
  End Sub

  Private Sub ResaltarPalabra(rtb As RichTextBox, palabra As String, color As Color)
    If Not String.IsNullOrEmpty(palabra) And rtb.Text.ToUpper().Contains(palabra.ToUpper()) Then
      Dim index As Integer = rtb.Text.ToUpper().IndexOf(palabra.ToUpper())
      While index <> -1
        rtb.Select(index, palabra.Length)
        rtb.SelectionBackColor = color
        index = rtb.Text.ToUpper().IndexOf(palabra.ToUpper(), index + 1)
      End While
      rtb.Select(0, 0)
    End If
  End Sub

End Class
