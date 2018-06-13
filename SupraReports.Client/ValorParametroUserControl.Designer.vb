<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValorParametroUserControl
  Inherits System.Windows.Forms.UserControl

  'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.TbValor = New System.Windows.Forms.TextBox()
    Me.LblNombre = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'TbValor
    '
    Me.TbValor.Location = New System.Drawing.Point(131, 3)
    Me.TbValor.Name = "TbValor"
    Me.TbValor.Size = New System.Drawing.Size(100, 20)
    Me.TbValor.TabIndex = 1
    '
    'LblNombre
    '
    Me.LblNombre.Location = New System.Drawing.Point(3, 3)
    Me.LblNombre.Name = "LblNombre"
    Me.LblNombre.Size = New System.Drawing.Size(122, 20)
    Me.LblNombre.TabIndex = 2
    Me.LblNombre.Text = "Nombre parámetro"
    Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ValorParametroUserControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.LblNombre)
    Me.Controls.Add(Me.TbValor)
    Me.Name = "ValorParametroUserControl"
    Me.Size = New System.Drawing.Size(234, 26)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TbValor As TextBox
  Friend WithEvents LblNombre As Label
End Class
