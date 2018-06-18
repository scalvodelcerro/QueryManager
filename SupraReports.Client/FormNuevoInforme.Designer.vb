<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoInforme
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TbNombre = New System.Windows.Forms.TextBox()
    Me.BtnOk = New System.Windows.Forms.Button()
    Me.BtnCancelar = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(101, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Nombre del informe:"
    '
    'TbNombre
    '
    Me.TbNombre.Location = New System.Drawing.Point(119, 12)
    Me.TbNombre.Name = "TbNombre"
    Me.TbNombre.Size = New System.Drawing.Size(234, 20)
    Me.TbNombre.TabIndex = 1
    '
    'BtnOk
    '
    Me.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.BtnOk.Location = New System.Drawing.Point(106, 38)
    Me.BtnOk.Name = "BtnOk"
    Me.BtnOk.Size = New System.Drawing.Size(75, 23)
    Me.BtnOk.TabIndex = 2
    Me.BtnOk.Text = "Aceptar"
    Me.BtnOk.UseVisualStyleBackColor = True
    '
    'BtnCancelar
    '
    Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.BtnCancelar.Location = New System.Drawing.Point(187, 38)
    Me.BtnCancelar.Name = "BtnCancelar"
    Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.BtnCancelar.TabIndex = 3
    Me.BtnCancelar.Text = "Cancelar"
    Me.BtnCancelar.UseVisualStyleBackColor = True
    '
    'FormNuevoInforme
    '
    Me.AcceptButton = Me.BtnOk
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.BtnCancelar
    Me.ClientSize = New System.Drawing.Size(368, 71)
    Me.ControlBox = False
    Me.Controls.Add(Me.BtnCancelar)
    Me.Controls.Add(Me.BtnOk)
    Me.Controls.Add(Me.TbNombre)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormNuevoInforme"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Nuevo informe"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents TbNombre As TextBox
  Friend WithEvents BtnOk As Button
  Friend WithEvents BtnCancelar As Button
End Class
