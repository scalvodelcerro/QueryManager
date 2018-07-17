<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResumenEjecuciones
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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.EjecucionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridEjecuciones = New SupraReports.Client.NestedPropertiesDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Informe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEjecucionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridColumnRutaFichero = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EjecucionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEjecuciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCerrar.Location = New System.Drawing.Point(476, 340)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'EjecucionBindingSource
        '
        Me.EjecucionBindingSource.DataSource = GetType(SupraReports.Model.Ejecucion)
        Me.EjecucionBindingSource.Sort = ""
        '
        'GridEjecuciones
        '
        Me.GridEjecuciones.AllowUserToAddRows = False
        Me.GridEjecuciones.AllowUserToDeleteRows = False
        Me.GridEjecuciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEjecuciones.AutoGenerateColumns = False
        Me.GridEjecuciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GridEjecuciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridEjecuciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Proyecto, Me.Informe, Me.HoraEjecucionColumn, Me.DataGridColumnRutaFichero, Me.DataGridViewTextBoxColumn4})
        Me.GridEjecuciones.DataSource = Me.EjecucionBindingSource
        Me.GridEjecuciones.Location = New System.Drawing.Point(12, 12)
        Me.GridEjecuciones.Name = "GridEjecuciones"
        Me.GridEjecuciones.ReadOnly = True
        Me.GridEjecuciones.RowHeadersVisible = False
        Me.GridEjecuciones.Size = New System.Drawing.Size(1003, 322)
        Me.GridEjecuciones.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 22
        '
        'Proyecto
        '
        Me.Proyecto.DataPropertyName = "Informe.Proyecto.Nombre"
        Me.Proyecto.HeaderText = "Proyecto"
        Me.Proyecto.Name = "Proyecto"
        Me.Proyecto.ReadOnly = True
        Me.Proyecto.Width = 74
        '
        'Informe
        '
        Me.Informe.DataPropertyName = "Informe.Nombre"
        Me.Informe.HeaderText = "Informe"
        Me.Informe.Name = "Informe"
        Me.Informe.ReadOnly = True
        Me.Informe.Width = 67
        '
        'HoraEjecucionColumn
        '
        Me.HoraEjecucionColumn.DataPropertyName = "HoraEjecucion"
        Me.HoraEjecucionColumn.HeaderText = "HoraEjecucion"
        Me.HoraEjecucionColumn.Name = "HoraEjecucionColumn"
        Me.HoraEjecucionColumn.ReadOnly = True
        Me.HoraEjecucionColumn.Width = 102
        '
        'DataGridColumnRutaFichero
        '
        Me.DataGridColumnRutaFichero.DataPropertyName = "RutaFichero"
        Me.DataGridColumnRutaFichero.HeaderText = "RutaFichero"
        Me.DataGridColumnRutaFichero.Name = "DataGridColumnRutaFichero"
        Me.DataGridColumnRutaFichero.ReadOnly = True
        Me.DataGridColumnRutaFichero.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridColumnRutaFichero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridColumnRutaFichero.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Resultado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Resultado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'FormResumenEjecuciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCerrar
        Me.ClientSize = New System.Drawing.Size(1027, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.GridEjecuciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormResumenEjecuciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resumen de ejecución de informes "
        CType(Me.EjecucionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEjecuciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

  Friend WithEvents EjecucionBindingSource As BindingSource
  Friend WithEvents GridEjecuciones As NestedPropertiesDataGridView
  Friend WithEvents BtnCerrar As Button
  Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Informe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraEjecucionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridColumnRutaFichero As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
