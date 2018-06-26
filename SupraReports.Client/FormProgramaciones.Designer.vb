<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProgramaciones
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.GridProgramaciones = New NestedPropertiesDataGridView()
    Me.ProgramacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.BtnAceptar = New System.Windows.Forms.Button()
    Me.BtnCancelar = New System.Windows.Forms.Button()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Informe = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New SupraReports.Client.DateTimePickerColumn()
    Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    CType(Me.GridProgramaciones, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ProgramacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GridProgramaciones
    '
    Me.GridProgramaciones.AllowUserToAddRows = False
    Me.GridProgramaciones.AllowUserToDeleteRows = False
    Me.GridProgramaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GridProgramaciones.AutoGenerateColumns = False
    Me.GridProgramaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.GridProgramaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Proyecto, Me.Informe, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7})
    Me.GridProgramaciones.DataSource = Me.ProgramacionBindingSource
    Me.GridProgramaciones.Location = New System.Drawing.Point(12, 12)
    Me.GridProgramaciones.Name = "GridProgramaciones"
    Me.GridProgramaciones.RowHeadersVisible = False
    Me.GridProgramaciones.Size = New System.Drawing.Size(544, 255)
    Me.GridProgramaciones.TabIndex = 1
    '
    'ProgramacionBindingSource
    '
    Me.ProgramacionBindingSource.AllowNew = False
    Me.ProgramacionBindingSource.DataSource = GetType(SupraReports.Model.Programacion)
    '
    'BtnAceptar
    '
    Me.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.BtnAceptar.Location = New System.Drawing.Point(206, 273)
    Me.BtnAceptar.Name = "BtnAceptar"
    Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
    Me.BtnAceptar.TabIndex = 2
    Me.BtnAceptar.Text = "Aceptar"
    Me.BtnAceptar.UseVisualStyleBackColor = True
    '
    'BtnCancelar
    '
    Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.BtnCancelar.Location = New System.Drawing.Point(287, 273)
    Me.BtnCancelar.Name = "BtnCancelar"
    Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.BtnCancelar.TabIndex = 3
    Me.BtnCancelar.Text = "Cancelar"
    Me.BtnCancelar.UseVisualStyleBackColor = True
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
    Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Visible = False
    '
    'Proyecto
    '
    Me.Proyecto.DataPropertyName = "Informe.Proyecto.Nombre"
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
    Me.Proyecto.DefaultCellStyle = DataGridViewCellStyle2
    Me.Proyecto.HeaderText = "Proyecto"
    Me.Proyecto.Name = "Proyecto"
    Me.Proyecto.ReadOnly = True
    '
    'Informe
    '
    Me.Informe.DataPropertyName = "Informe.Nombre"
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight
    Me.Informe.DefaultCellStyle = DataGridViewCellStyle3
    Me.Informe.HeaderText = "Informe"
    Me.Informe.Name = "Informe"
    Me.Informe.ReadOnly = True
    Me.Informe.Width = 200
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "Hora"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Hora"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    '
    'DataGridViewCheckBoxColumn1
    '
    Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Lunes"
    Me.DataGridViewCheckBoxColumn1.HeaderText = "L"
    Me.DataGridViewCheckBoxColumn1.MinimumWidth = 20
    Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
    Me.DataGridViewCheckBoxColumn1.Width = 20
    '
    'DataGridViewCheckBoxColumn2
    '
    Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Martes"
    Me.DataGridViewCheckBoxColumn2.HeaderText = "M"
    Me.DataGridViewCheckBoxColumn2.MinimumWidth = 20
    Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
    Me.DataGridViewCheckBoxColumn2.Width = 20
    '
    'DataGridViewCheckBoxColumn3
    '
    Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Miercoles"
    Me.DataGridViewCheckBoxColumn3.HeaderText = "X"
    Me.DataGridViewCheckBoxColumn3.MinimumWidth = 20
    Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
    Me.DataGridViewCheckBoxColumn3.Width = 20
    '
    'DataGridViewCheckBoxColumn4
    '
    Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Jueves"
    Me.DataGridViewCheckBoxColumn4.HeaderText = "J"
    Me.DataGridViewCheckBoxColumn4.MinimumWidth = 20
    Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
    Me.DataGridViewCheckBoxColumn4.Width = 20
    '
    'DataGridViewCheckBoxColumn5
    '
    Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Viernes"
    Me.DataGridViewCheckBoxColumn5.HeaderText = "V"
    Me.DataGridViewCheckBoxColumn5.MinimumWidth = 20
    Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
    Me.DataGridViewCheckBoxColumn5.Width = 20
    '
    'DataGridViewCheckBoxColumn6
    '
    Me.DataGridViewCheckBoxColumn6.DataPropertyName = "Sabado"
    Me.DataGridViewCheckBoxColumn6.HeaderText = "S"
    Me.DataGridViewCheckBoxColumn6.MinimumWidth = 20
    Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
    Me.DataGridViewCheckBoxColumn6.Width = 20
    '
    'DataGridViewCheckBoxColumn7
    '
    Me.DataGridViewCheckBoxColumn7.DataPropertyName = "Domingo"
    Me.DataGridViewCheckBoxColumn7.HeaderText = "D"
    Me.DataGridViewCheckBoxColumn7.MinimumWidth = 20
    Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
    Me.DataGridViewCheckBoxColumn7.Width = 20
    '
    'FormProgramaciones
    '
    Me.AcceptButton = Me.BtnAceptar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.BtnCancelar
    Me.ClientSize = New System.Drawing.Size(568, 308)
    Me.ControlBox = False
    Me.Controls.Add(Me.BtnCancelar)
    Me.Controls.Add(Me.BtnAceptar)
    Me.Controls.Add(Me.GridProgramaciones)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "FormProgramaciones"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Programaciones de informes"
    CType(Me.GridProgramaciones, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ProgramacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents ProgramacionBindingSource As BindingSource
  Friend WithEvents GridProgramaciones As NestedPropertiesDataGridView
  Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
  Friend WithEvents BtnAceptar As Button
  Friend WithEvents BtnCancelar As Button
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents Proyecto As DataGridViewTextBoxColumn
  Friend WithEvents Informe As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DateTimePickerColumn
  Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewCheckBoxColumn7 As DataGridViewCheckBoxColumn
End Class
