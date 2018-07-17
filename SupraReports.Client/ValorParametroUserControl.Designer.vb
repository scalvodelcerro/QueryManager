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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.LblNombre.Location = New System.Drawing.Point(3, 2)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(112, 20)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre parámetro"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValorParametroUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TbValor)
        Me.Name = "ValorParametroUserControl"
        Me.Size = New System.Drawing.Size(234, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents TbValor As TextBox
  Friend WithEvents LblNombre As Label
  Friend WithEvents Label1 As Label
End Class
