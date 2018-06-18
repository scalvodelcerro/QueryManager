<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProgramacionInforme
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
    Me.BtnCancelar = New System.Windows.Forms.Button()
    Me.BtnOk = New System.Windows.Forms.Button()
    Me.CbLunes = New System.Windows.Forms.CheckBox()
    Me.CbMartes = New System.Windows.Forms.CheckBox()
    Me.CbMiercoles = New System.Windows.Forms.CheckBox()
    Me.CbJueves = New System.Windows.Forms.CheckBox()
    Me.CbViernes = New System.Windows.Forms.CheckBox()
    Me.CbSabado = New System.Windows.Forms.CheckBox()
    Me.CbDomingo = New System.Windows.Forms.CheckBox()
    Me.PickerHora = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'BtnCancelar
    '
    Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.BtnCancelar.Location = New System.Drawing.Point(116, 100)
    Me.BtnCancelar.Name = "BtnCancelar"
    Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.BtnCancelar.TabIndex = 5
    Me.BtnCancelar.Text = "Cancelar"
    Me.BtnCancelar.UseVisualStyleBackColor = True
    '
    'BtnOk
    '
    Me.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.BtnOk.Location = New System.Drawing.Point(35, 100)
    Me.BtnOk.Name = "BtnOk"
    Me.BtnOk.Size = New System.Drawing.Size(75, 23)
    Me.BtnOk.TabIndex = 4
    Me.BtnOk.Text = "Aceptar"
    Me.BtnOk.UseVisualStyleBackColor = True
    '
    'CbLunes
    '
    Me.CbLunes.AutoSize = True
    Me.CbLunes.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.CbLunes.Location = New System.Drawing.Point(35, 42)
    Me.CbLunes.Name = "CbLunes"
    Me.CbLunes.Size = New System.Drawing.Size(17, 31)
    Me.CbLunes.TabIndex = 6
    Me.CbLunes.Text = "L"
    Me.CbLunes.UseVisualStyleBackColor = True
    '
    'CbMartes
    '
    Me.CbMartes.AutoSize = True
    Me.CbMartes.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.CbMartes.Location = New System.Drawing.Point(58, 42)
    Me.CbMartes.Name = "CbMartes"
    Me.CbMartes.Size = New System.Drawing.Size(20, 31)
    Me.CbMartes.TabIndex = 7
    Me.CbMartes.Text = "M"
    Me.CbMartes.UseVisualStyleBackColor = True
    '
    'CbMiercoles
    '
    Me.CbMiercoles.AutoSize = True
    Me.CbMiercoles.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.CbMiercoles.Location = New System.Drawing.Point(81, 42)
    Me.CbMiercoles.Name = "CbMiercoles"
    Me.CbMiercoles.Size = New System.Drawing.Size(18, 31)
    Me.CbMiercoles.TabIndex = 8
    Me.CbMiercoles.Text = "X"
    Me.CbMiercoles.UseVisualStyleBackColor = True
    '
    'CbJueves
    '
    Me.CbJueves.AutoSize = True
    Me.CbJueves.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.CbJueves.Location = New System.Drawing.Point(104, 42)
    Me.CbJueves.Name = "CbJueves"
    Me.CbJueves.Size = New System.Drawing.Size(16, 31)
    Me.CbJueves.TabIndex = 9
    Me.CbJueves.Text = "J"
    Me.CbJueves.UseVisualStyleBackColor = True
    '
    'CbViernes
    '
    Me.CbViernes.AutoSize = True
    Me.CbViernes.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.CbViernes.Location = New System.Drawing.Point(127, 42)
    Me.CbViernes.Name = "CbViernes"
    Me.CbViernes.Size = New System.Drawing.Size(18, 31)
    Me.CbViernes.TabIndex = 10
    Me.CbViernes.Text = "V"
    Me.CbViernes.UseVisualStyleBackColor = True
    '
    'CbSabado
    '
    Me.CbSabado.AutoSize = True
    Me.CbSabado.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.CbSabado.Location = New System.Drawing.Point(150, 42)
    Me.CbSabado.Name = "CbSabado"
    Me.CbSabado.Size = New System.Drawing.Size(18, 31)
    Me.CbSabado.TabIndex = 11
    Me.CbSabado.Text = "S"
    Me.CbSabado.UseVisualStyleBackColor = True
    '
    'CbDomingo
    '
    Me.CbDomingo.AutoSize = True
    Me.CbDomingo.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.CbDomingo.Location = New System.Drawing.Point(173, 42)
    Me.CbDomingo.Name = "CbDomingo"
    Me.CbDomingo.Size = New System.Drawing.Size(19, 31)
    Me.CbDomingo.TabIndex = 12
    Me.CbDomingo.Text = "D"
    Me.CbDomingo.UseVisualStyleBackColor = True
    '
    'PickerHora
    '
    Me.PickerHora.CustomFormat = "hh:mm"
    Me.PickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.PickerHora.Location = New System.Drawing.Point(71, 16)
    Me.PickerHora.Name = "PickerHora"
    Me.PickerHora.ShowUpDown = True
    Me.PickerHora.Size = New System.Drawing.Size(74, 20)
    Me.PickerHora.TabIndex = 13
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(32, 20)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(33, 13)
    Me.Label1.TabIndex = 14
    Me.Label1.Text = "Hora:"
    '
    'FormProgramacionInforme
    '
    Me.AcceptButton = Me.BtnOk
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.BtnCancelar
    Me.ClientSize = New System.Drawing.Size(227, 138)
    Me.ControlBox = False
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.PickerHora)
    Me.Controls.Add(Me.CbDomingo)
    Me.Controls.Add(Me.CbSabado)
    Me.Controls.Add(Me.CbViernes)
    Me.Controls.Add(Me.CbJueves)
    Me.Controls.Add(Me.CbMiercoles)
    Me.Controls.Add(Me.CbMartes)
    Me.Controls.Add(Me.CbLunes)
    Me.Controls.Add(Me.BtnCancelar)
    Me.Controls.Add(Me.BtnOk)
    Me.Name = "FormProgramacionInforme"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Programación del informe"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents BtnCancelar As Button
  Friend WithEvents BtnOk As Button
  Friend WithEvents CbLunes As CheckBox
  Friend WithEvents CbMartes As CheckBox
  Friend WithEvents CbMiercoles As CheckBox
  Friend WithEvents CbJueves As CheckBox
  Friend WithEvents CbViernes As CheckBox
  Friend WithEvents CbSabado As CheckBox
  Friend WithEvents CbDomingo As CheckBox
  Friend WithEvents PickerHora As DateTimePicker
  Friend WithEvents Label1 As Label
End Class
