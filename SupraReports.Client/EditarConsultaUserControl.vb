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
        TbSql.Sugerencias = New Collection(Of String)(ParametroDefecto.Todos)
    End Sub

    Public WriteOnly Property Consulta As Consulta
        Set(value As Consulta)
            _consulta = value
            If _consulta IsNot Nothing Then
                TbNombre.Text = _consulta.Nombre
                TbSql.Text = _consulta.TextoSql
                CbHabilitada.Checked = _consulta.Habilitada
                CargarParametros()
            End If
        End Set
    End Property
    Private _consulta As Consulta

    Private Sub TbNombre_TextChanged(sender As Object, e As EventArgs) Handles TbNombre.TextChanged
        _consulta.Nombre = TbNombre.Text
    End Sub

    Private Sub CbHabilitada_CheckedChanged(sender As Object, e As EventArgs) Handles CbHabilitada.CheckedChanged
        _consulta.Habilitada = CbHabilitada.Checked
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
                Dim parametro = _consulta.Informe.Consultas.SelectMany(Function(x) x.Parametros.Where(Function(xx) xx.Nombre = nombreParametro)).FirstOrDefault()
                If parametro Is Nothing Then
                    _consulta.AnadirParametro(nombreParametro, String.Empty)
                Else
                    _consulta.AnadirParametro(nombreParametro, parametro.Valor)
                End If
            Next
            CargarParametros()

        End If
    End Sub

    Private Sub BtnEliminarConsulta_Click(sender As Object, e As EventArgs) Handles BtnEliminarConsulta.Click
        If MessageBox.Show(Me, "¿Desea eliminar la consulta?", "Confirmar eliminación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            db.Consultas.Remove(_consulta)
            Dispose()
        End If
    End Sub

    Private Sub BtnPrevisualizar_Click(sender As Object, e As EventArgs) Handles BtnPrevisualizar.Click
        Dim formPrevisualizar = New FormPrevisualizarConsulta()
        If _consulta IsNot Nothing Then
            formPrevisualizar.TbSql.AppendText(_consulta.ComponerSqlResultado())
            formPrevisualizar.ShowDialog(Me)
        End If
    End Sub

    Private Sub OnSeleccionarParametro(sender As Object, e As EventArgs)
        Dim control = CType(CType(sender, TextBox).Parent, ValorParametroUserControl)
        ResaltarParametro(control.LblNombre.Text, control.TbValor.Text, colorResaltarTexto)
    End Sub

    Private Sub OnDeseleccionarParametro(sender As Object, e As EventArgs)
        LimpiarResaltado(TbSql)
    End Sub

    Private Sub CargarParametros()
        PnlParametros.Controls.Clear()
        For Each p In _consulta.Parametros.OrderBy(Function(x) x.Nombre)
            Dim control As ValorParametroUserControl = New ValorParametroUserControl(p)
            AddHandler control.TbValor.GotFocus, AddressOf OnSeleccionarParametro
            AddHandler control.TbValor.LostFocus, AddressOf OnDeseleccionarParametro
            PnlParametros.Controls.Add(control)
        Next
        Dim pattern = "#@(\w+)([\+\-]\d+)?#"

        If _consulta.TextoSql IsNot Nothing Then
            For Each m In Regex.Matches(_consulta.TextoSql.ToUpper(), pattern).Cast(Of Match)().Select(Function(x) x.Groups(1).Value).Distinct()
                Dim p = ParametroDefecto.ObtenerParametroDefecto(m)
                If p IsNot Nothing Then
                    Dim control As ValorParametroDefectoUserControl = New ValorParametroDefectoUserControl(m, p.Valor)
                    AddHandler control.TbValor.GotFocus, AddressOf OnSeleccionarParametro
                    AddHandler control.TbValor.LostFocus, AddressOf OnDeseleccionarParametro
                    PnlParametros.Controls.Add(control)
                End If
            Next
        End If
    End Sub

    Private Sub LimpiarResaltado(rtb As RichTextBox)
        Dim text = rtb.Text.ToString()
        rtb.Clear()
        rtb.Text = text
    End Sub

    Private Sub ResaltarParametro(nombreParametro As String, valor As String, color As Color)
        LimpiarResaltado(TbSql)
        ResaltarPalabra(TbSql, String.Format("#{0}#", nombreParametro), color)
        ResaltarPalabra(TbSql, String.Format("#@{0}#", nombreParametro), color)
    End Sub

    Private Sub ResaltarPalabra(rtb As RichTextBox, palabra As String, color As Color)
        If Not String.IsNullOrEmpty(palabra) And rtb.Text.ToUpper().Contains(palabra.ToUpper()) Then
            Dim index As Integer = rtb.Text.ToUpper().IndexOf(palabra.ToUpper())
            While index <> -1
                rtb.Select(index, palabra.Length)
                rtb.SelectionBackColor = color
                index = rtb.Text.ToUpper().IndexOf(palabra.ToUpper(), index + 1)
                rtb.ScrollToCaret()
            End While
            rtb.Select(0, 0)
        End If
    End Sub
End Class
