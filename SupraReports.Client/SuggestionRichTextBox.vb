Imports System.Collections.ObjectModel

Public Class SuggestionRichTextBox
  Public Sub New()
    InitializeComponent()
  End Sub

  Public Property Suggestions As Collection(Of String)
    Get
      Return _suggestions
    End Get
    Set(value As Collection(Of String))
      _suggestions = value
      LbSuggestions.Items.Clear()
      LbSuggestions.Items.AddRange(_suggestions.ToArray())
    End Set
  End Property
  Private _suggestions As Collection(Of String) = New Collection(Of String)()

  Private Sub SuggestionRichTextBox_ParentChanged(sender As Object, e As EventArgs) Handles MyBase.ParentChanged
    Parent.Controls.Add(LbSuggestions)
  End Sub

  Private Sub SuggestionRichTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.Down And LbSuggestions.Visible Then
      LbSuggestions.Focus()
      LbSuggestions.SelectedIndex = 0
      e.Handled = True
    End If
  End Sub

  Private Sub SuggestionRichTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
    If e.KeyCode <> Keys.Back Then
      ShowSuggestionList()
    End If
  End Sub

  Private Sub LbSuggestions_KeyDown(sender As Object, e As KeyEventArgs) Handles LbSuggestions.KeyDown
    If e.KeyCode = Keys.Enter Then
      InsertText()
    End If
  End Sub

  Private Sub LbSuggestions_KeyDown(sender As Object, e As MouseEventArgs) Handles LbSuggestions.MouseDoubleClick
    InsertText()
  End Sub

  Private Sub InsertText()
    SelectionLength = 0
    SelectedText = LbSuggestions.SelectedItem
    Focus()
    LbSuggestions.Visible = False
  End Sub

  Private Sub ShowSuggestionList()
    If SelectionStart > 0 Then
      Dim c = Text(SelectionStart - 1)
      If c = "#"c Then
        Dim cursorPosition = GetPositionFromCharIndex(SelectionStart)

        LbSuggestions.Location = New Point(cursorPosition.X + 10, cursorPosition.Y + 20)
        LbSuggestions.BringToFront()
        LbSuggestions.ClearSelected()
        LbSuggestions.Visible = True
      Else
        LbSuggestions.Visible = False
      End If
    End If
  End Sub
End Class
