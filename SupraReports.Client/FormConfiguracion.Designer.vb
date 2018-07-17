<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfiguracion
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
        Me.TbDirectorioSalida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnExaminarDirectorioSalida = New System.Windows.Forms.Button()
        Me.FolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbDirectorioSalida
        '
        Me.TbDirectorioSalida.Location = New System.Drawing.Point(170, 14)
        Me.TbDirectorioSalida.Name = "TbDirectorioSalida"
        Me.TbDirectorioSalida.Size = New System.Drawing.Size(288, 20)
        Me.TbDirectorioSalida.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ruta de informes por defecto:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnAceptar.Location = New System.Drawing.Point(200, 47)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnExaminarDirectorioSalida
        '
        Me.BtnExaminarDirectorioSalida.Location = New System.Drawing.Point(464, 12)
        Me.BtnExaminarDirectorioSalida.Name = "BtnExaminarDirectorioSalida"
        Me.BtnExaminarDirectorioSalida.Size = New System.Drawing.Size(75, 23)
        Me.BtnExaminarDirectorioSalida.TabIndex = 3
        Me.BtnExaminarDirectorioSalida.Text = "Examinar..."
        Me.BtnExaminarDirectorioSalida.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(281, 47)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FormConfiguracion
        '
        Me.AcceptButton = Me.BtnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(556, 82)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnExaminarDirectorioSalida)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbDirectorioSalida)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

  Friend WithEvents TbDirectorioSalida As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents BtnAceptar As Button
  Friend WithEvents BtnExaminarDirectorioSalida As Button
  Friend WithEvents FolderDialog As FolderBrowserDialog
  Friend WithEvents BtnCancelar As Button
End Class
