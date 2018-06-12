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
    Me.TbParametro = New System.Windows.Forms.TextBox()
    Me.TbValor = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'TbParametro
    '
    Me.TbParametro.BackColor = System.Drawing.SystemColors.Window
    Me.TbParametro.Location = New System.Drawing.Point(3, 3)
    Me.TbParametro.Name = "TbParametro"
    Me.TbParametro.ReadOnly = True
    Me.TbParametro.Size = New System.Drawing.Size(100, 20)
    Me.TbParametro.TabIndex = 0
    '
    'TbValor
    '
    Me.TbValor.Location = New System.Drawing.Point(131, 3)
    Me.TbValor.Name = "TbValor"
    Me.TbValor.Size = New System.Drawing.Size(100, 20)
    Me.TbValor.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(109, 6)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(16, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "->"
    '
    'ValorParametroUserControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.TbValor)
    Me.Controls.Add(Me.TbParametro)
    Me.Name = "ValorParametroUserControl"
    Me.Size = New System.Drawing.Size(234, 26)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents TbParametro As TextBox
  Friend WithEvents TbValor As TextBox
  Friend WithEvents Label1 As Label
End Class
