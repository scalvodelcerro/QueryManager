<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
    Me.Tabs = New System.Windows.Forms.TabControl()
    Me.TabCrear = New System.Windows.Forms.TabPage()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
    Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
    Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.BtnAnadirConsulta = New System.Windows.Forms.ToolStripButton()
    Me.LblInforme = New System.Windows.Forms.Label()
    Me.CbInforme = New System.Windows.Forms.ComboBox()
    Me.PnlEditar = New System.Windows.Forms.FlowLayoutPanel()
    Me.TabUsar = New System.Windows.Forms.TabPage()
    Me.PnlUsar = New System.Windows.Forms.FlowLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.CbInformeUsar = New System.Windows.Forms.ComboBox()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.Tabs.SuspendLayout()
    Me.TabCrear.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.TabUsar.SuspendLayout()
    Me.SuspendLayout()
    '
    'Tabs
    '
    Me.Tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Tabs.Controls.Add(Me.TabCrear)
    Me.Tabs.Controls.Add(Me.TabUsar)
    Me.Tabs.Location = New System.Drawing.Point(12, 12)
    Me.Tabs.Name = "Tabs"
    Me.Tabs.SelectedIndex = 0
    Me.Tabs.Size = New System.Drawing.Size(1160, 494)
    Me.Tabs.TabIndex = 2
    '
    'TabCrear
    '
    Me.TabCrear.Controls.Add(Me.ToolStrip1)
    Me.TabCrear.Controls.Add(Me.LblInforme)
    Me.TabCrear.Controls.Add(Me.CbInforme)
    Me.TabCrear.Controls.Add(Me.PnlEditar)
    Me.TabCrear.Location = New System.Drawing.Point(4, 22)
    Me.TabCrear.Name = "TabCrear"
    Me.TabCrear.Padding = New System.Windows.Forms.Padding(3)
    Me.TabCrear.Size = New System.Drawing.Size(1152, 468)
    Me.TabCrear.TabIndex = 0
    Me.TabCrear.Text = "Crear Informe"
    Me.TabCrear.UseVisualStyleBackColor = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnGuardar, Me.ToolStripSeparator2, Me.toolStripSeparator1, Me.BtnAnadirConsulta})
    Me.ToolStrip1.Location = New System.Drawing.Point(409, 6)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(84, 25)
    Me.ToolStrip1.TabIndex = 0
    '
    'BtnNuevo
    '
    Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
    Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.BtnNuevo.Name = "BtnNuevo"
    Me.BtnNuevo.Size = New System.Drawing.Size(23, 22)
    Me.BtnNuevo.Text = "&Nuevo informe"
    '
    'BtnGuardar
    '
    Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
    Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.BtnGuardar.Name = "BtnGuardar"
    Me.BtnGuardar.Size = New System.Drawing.Size(23, 22)
    Me.BtnGuardar.Text = "&Guardar informe"
    '
    'toolStripSeparator1
    '
    Me.toolStripSeparator1.Name = "toolStripSeparator1"
    Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'BtnAnadirConsulta
    '
    Me.BtnAnadirConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BtnAnadirConsulta.Image = CType(resources.GetObject("BtnAnadirConsulta.Image"), System.Drawing.Image)
    Me.BtnAnadirConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.BtnAnadirConsulta.Name = "BtnAnadirConsulta"
    Me.BtnAnadirConsulta.Size = New System.Drawing.Size(23, 22)
    Me.BtnAnadirConsulta.Text = "Añadir Consulta"
    Me.BtnAnadirConsulta.ToolTipText = "Añadir Consulta"
    '
    'LblInforme
    '
    Me.LblInforme.AutoSize = True
    Me.LblInforme.Location = New System.Drawing.Point(9, 12)
    Me.LblInforme.Name = "LblInforme"
    Me.LblInforme.Size = New System.Drawing.Size(45, 13)
    Me.LblInforme.TabIndex = 2
    Me.LblInforme.Text = "Informe:"
    '
    'CbInforme
    '
    Me.CbInforme.FormattingEnabled = True
    Me.CbInforme.Location = New System.Drawing.Point(60, 8)
    Me.CbInforme.Name = "CbInforme"
    Me.CbInforme.Size = New System.Drawing.Size(346, 21)
    Me.CbInforme.TabIndex = 1
    '
    'PnlEditar
    '
    Me.PnlEditar.AutoScroll = True
    Me.PnlEditar.Location = New System.Drawing.Point(0, 34)
    Me.PnlEditar.Name = "PnlEditar"
    Me.PnlEditar.Size = New System.Drawing.Size(1152, 434)
    Me.PnlEditar.TabIndex = 0
    '
    'TabUsar
    '
    Me.TabUsar.Controls.Add(Me.PnlUsar)
    Me.TabUsar.Controls.Add(Me.Label1)
    Me.TabUsar.Controls.Add(Me.CbInformeUsar)
    Me.TabUsar.Location = New System.Drawing.Point(4, 22)
    Me.TabUsar.Name = "TabUsar"
    Me.TabUsar.Padding = New System.Windows.Forms.Padding(3)
    Me.TabUsar.Size = New System.Drawing.Size(1152, 468)
    Me.TabUsar.TabIndex = 1
    Me.TabUsar.Text = "Usar informe"
    Me.TabUsar.UseVisualStyleBackColor = True
    '
    'PnlUsar
    '
    Me.PnlUsar.AutoScroll = True
    Me.PnlUsar.Location = New System.Drawing.Point(0, 35)
    Me.PnlUsar.Name = "PnlUsar"
    Me.PnlUsar.Size = New System.Drawing.Size(1152, 434)
    Me.PnlUsar.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(45, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Informe:"
    '
    'CbInformeUsar
    '
    Me.CbInformeUsar.FormattingEnabled = True
    Me.CbInformeUsar.Location = New System.Drawing.Point(60, 8)
    Me.CbInformeUsar.Name = "CbInformeUsar"
    Me.CbInformeUsar.Size = New System.Drawing.Size(346, 21)
    Me.CbInformeUsar.TabIndex = 3
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'FormPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1184, 514)
    Me.Controls.Add(Me.Tabs)
    Me.Name = "FormPrincipal"
    Me.Text = "Informes Supra"
    Me.Tabs.ResumeLayout(False)
    Me.TabCrear.ResumeLayout(False)
    Me.TabCrear.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.TabUsar.ResumeLayout(False)
    Me.TabUsar.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Tabs As TabControl
  Friend WithEvents TabCrear As TabPage
  Friend WithEvents TabUsar As TabPage
  Friend WithEvents PnlEditar As FlowLayoutPanel
  Friend WithEvents LblInforme As Label
  Friend WithEvents CbInforme As ComboBox
  Friend WithEvents ToolStrip1 As ToolStrip
  Friend WithEvents BtnNuevo As ToolStripButton
  Friend WithEvents BtnGuardar As ToolStripButton
  Friend WithEvents toolStripSeparator1 As ToolStripSeparator
  Friend WithEvents BtnAnadirConsulta As ToolStripButton
  Friend WithEvents Label1 As Label
  Friend WithEvents CbInformeUsar As ComboBox
  Friend WithEvents PnlUsar As FlowLayoutPanel
  Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
