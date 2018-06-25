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
    If e.KeyCode <> Keys.Back Then
      MostrarListadoSugerencias()
    End If
  End Sub

  Private Sub LbSuggestions_KeyDown(sender As Object, e As KeyEventArgs) Handles LbSugerencias.KeyDown
    If e.KeyCode = Keys.Enter Then
      InsertarSugerencia()
    End If
  End Sub

  Private Sub LbSuggestions_KeyDown(sender As Object, e As MouseEventArgs) Handles LbSugerencias.MouseDoubleClick
    InsertarSugerencia()
  End Sub

  Private Sub InsertarSugerencia()
    SelectionLength = 0
    SelectedText = LbSugerencias.SelectedItem
    Focus()
    LbSugerencias.Visible = False
  End Sub

  Private Sub MostrarListadoSugerencias()
    If SelectionStart > 0 Then
      Dim c = Text(SelectionStart - 1)
      If c = "#"c Then
        PosicionarListadoSugerencias()

        LbSugerencias.BringToFront()
        LbSugerencias.ClearSelected()
        LbSugerencias.Visible = True
      Else
        LbSugerencias.Visible = False
      End If
    End If
  End Sub

  Private Sub PosicionarListadoSugerencias()
    Dim cursorPosition = GetPositionFromCharIndex(SelectionStart)
    Dim x As Integer
    If Parent IsNot Nothing AndAlso Location.X + cursorPosition.X + LbSugerencias.Width > Parent.Width Then
      x = Parent.Width - LbSugerencias.Width
    Else
      x = cursorPosition.X + Location.X
    End If
    Dim y As Integer
    If Parent IsNot Nothing AndAlso Location.Y + cursorPosition.Y + LbSugerencias.Height > Parent.Height Then
      y = Parent.Height - LbSugerencias.Height
    Else
      y = cursorPosition.Y + Location.Y
    End If
    LbSugerencias.Location = New Point(x, y)
  End Sub
End Class
