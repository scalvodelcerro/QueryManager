<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuggestionRichTextBox
  Inherits RichTextBox

  'Control reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requerido por el Diseñador de controles
  Private components As System.ComponentModel.IContainer

  ' NOTA: el Diseñador de componentes requiere el siguiente procedimiento
  ' Se puede modificar usando el Diseñador de componentes.  No lo modifique
  ' usando el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.LbSugerencias = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'LbSuggestions
    '
    Me.LbSugerencias.FormattingEnabled = True
    Me.LbSugerencias.Location = New System.Drawing.Point(0, 0)
    Me.LbSugerencias.MaximumSize = New System.Drawing.Size(100, 100)
    Me.LbSugerencias.MinimumSize = New System.Drawing.Size(100, 100)
    Me.LbSugerencias.Name = "LbSuggestions"
    Me.LbSugerencias.Size = New System.Drawing.Size(100, 100)
    Me.LbSugerencias.TabIndex = 0
    Me.LbSugerencias.Visible = False
    '
    'SuggestionRichTextBox
    '
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents LbSugerencias As ListBox
End Class

