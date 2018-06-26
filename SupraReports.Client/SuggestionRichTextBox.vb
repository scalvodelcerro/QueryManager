Imports System.Collections.ObjectModel

Public Class SuggestionRichTextBox
  Public Sub New()
    InitializeComponent()
  End Sub

  Public Property Sugerencias As Collection(Of String)
    Get
      Return _sugerencias
    End Get
    Set(value As Collection(Of String))
      _sugerencias = value
      LbSugerencias.Items.Clear()
      LbSugerencias.Items.AddRange(_sugerencias.ToArray())
    End Set
  End Property
  Private _sugerencias As Collection(Of String) = New Collection(Of String)()

  Private Sub SuggestionRichTextBox_ParentChanged(sender As Object, e As EventArgs) Handles MyBase.ParentChanged
    Parent.Controls.Add(LbSugerencias)
  End Sub

  Private Sub SuggestionRichTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.Down And LbSugerencias.Visible Then
      LbSugerencias.Focus()
      LbSugerencias.SelectedIndex = 0
      e.Handled = True
    End If
  End Sub

  Private Sub SuggestionRichTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
    If e.KeyCode <> Keys.Back AndAlso DebeMostrarListadoSugerencias() Then
      MostrarListadoSugerencias()
    Else
      OcultarListadoSugerencias()
    End If
  End Sub

  Private Sub SuggestionRichTextBox_Click(sender As Object, e As EventArgs) Handles MyBase.Click
    OcultarListadoSugerencias()
  End Sub

  Private Sub LbSuggestions_KeyDown(sender As Object, e As KeyEventArgs) Handles LbSugerencias.KeyDown
    If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab OrElse e.KeyCode = Keys.Space Then
      InsertarSugerencia()
      e.Handled = True
    End If
  End Sub

  Private Sub LbSugerencias_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles LbSugerencias.PreviewKeyDown
    If e.KeyCode = Keys.Tab Then
      e.IsInputKey = True
    End If
  End Sub

  Private Sub LbSuggestions_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LbSugerencias.MouseDoubleClick
    InsertarSugerencia()
  End Sub

  Private Function DebeMostrarListadoSugerencias() As Boolean
    If SelectionStart <= 0 Then Return False
    Dim c = Text(SelectionStart - 1)
    If c <> "#"c Then Return False
    If (Text.Count(Function(x) x = "#"c) Mod 2) = 0 Then Return False
    Return True
  End Function

  Private Sub MostrarListadoSugerencias()
    PosicionarListadoSugerencias()
    LbSugerencias.BringToFront()
    LbSugerencias.ClearSelected()
    LbSugerencias.Visible = True
  End Sub

  Private Sub PosicionarListadoSugerencias()
    Dim cursorPosition = GetPositionFromCharIndex(SelectionStart)
    Dim x As Integer
    If Parent IsNot Nothing AndAlso Location.X + cursorPosition.X + LbSugerencias.Width > Parent.Width Then
      x = Parent.Width - LbSugerencias.Width
    Else
      x = cursorPosition.X + Location.X
    End If
    Dim offsetY As Integer = 20
    Dim y As Integer
    If Parent IsNot Nothing AndAlso Location.Y + cursorPosition.Y + offsetY + LbSugerencias.Height > Parent.Height Then
      y = Parent.Height - LbSugerencias.Height
    Else
      y = Location.Y + cursorPosition.Y + offsetY
    End If
    LbSugerencias.Location = New Point(x, y)
  End Sub

  Private Sub OcultarListadoSugerencias()
    LbSugerencias.Visible = False
  End Sub

  Private Sub InsertarSugerencia()
    Focus()
    SelectionLength = 0
    SelectedText = LbSugerencias.SelectedItem + "#"c
    LbSugerencias.Visible = False
  End Sub

End Class
