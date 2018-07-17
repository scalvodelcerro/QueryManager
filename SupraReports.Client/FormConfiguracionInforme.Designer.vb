<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfiguracionInforme
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnExaminarDirectorioSalida = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbDirectorioSalida = New System.Windows.Forms.TextBox()
        Me.FolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(272, 47)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnAceptar.Location = New System.Drawing.Point(191, 47)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnExaminarDirectorioSalida
        '
        Me.BtnExaminarDirectorioSalida.Location = New System.Drawing.Point(447, 12)
        Me.BtnExaminarDirectorioSalida.Name = "BtnExaminarDirectorioSalida"
        Me.BtnExaminarDirectorioSalida.Size = New System.Drawing.Size(75, 23)
        Me.BtnExaminarDirectorioSalida.TabIndex = 9
        Me.BtnExaminarDirectorioSalida.Text = "Examinar..."
        Me.BtnExaminarDirectorioSalida.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ruta de salida de informe:"
        '
        'TbDirectorioSalida
        '
        Me.TbDirectorioSalida.Location = New System.Drawing.Point(153, 14)
        Me.TbDirectorioSalida.Name = "TbDirectorioSalida"
        Me.TbDirectorioSalida.Size = New System.Drawing.Size(288, 20)
        Me.TbDirectorioSalida.TabIndex = 7
        '
        'FormConfiguracionInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 82)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExaminarDirectorioSalida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbDirectorioSalida)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormConfiguracionInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración del informe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnExaminarDirectorioSalida As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbDirectorioSalida As System.Windows.Forms.TextBox
    Friend WithEvents FolderDialog As System.Windows.Forms.FolderBrowserDialog
End Class
