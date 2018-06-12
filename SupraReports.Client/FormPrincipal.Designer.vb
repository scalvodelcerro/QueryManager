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
    Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
    Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
    Me.LblInforme = New System.Windows.Forms.Label()
    Me.CbInforme = New System.Windows.Forms.ComboBox()
    Me.PnlUsar = New System.Windows.Forms.FlowLayoutPanel()
    Me.TabUsar = New System.Windows.Forms.TabPage()
    Me.BtnAnadirConsulta = New System.Windows.Forms.ToolStripButton()
    Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.Tabs.SuspendLayout()
    Me.TabCrear.SuspendLayout()
    Me.ToolStripContainer1.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Tabs
    '
    Me.Tabs.Controls.Add(Me.TabCrear)
    Me.Tabs.Controls.Add(Me.TabUsar)
    Me.Tabs.Location = New System.Drawing.Point(12, 12)
    Me.Tabs.Name = "Tabs"
    Me.Tabs.SelectedIndex = 0
    Me.Tabs.Size = New System.Drawing.Size(890, 395)
    Me.Tabs.TabIndex = 2
    '
    'TabCrear
    '
    Me.TabCrear.Controls.Add(Me.ToolStrip1)
    Me.TabCrear.Controls.Add(Me.LblInforme)
    Me.TabCrear.Controls.Add(Me.CbInforme)
    Me.TabCrear.Controls.Add(Me.PnlUsar)
    Me.TabCrear.Location = New System.Drawing.Point(4, 22)
    Me.TabCrear.Name = "TabCrear"
    Me.TabCrear.Padding = New System.Windows.Forms.Padding(3)
    Me.TabCrear.Size = New System.Drawing.Size(882, 369)
    Me.TabCrear.TabIndex = 0
    Me.TabCrear.Text = "Crear Informe"
    Me.TabCrear.UseVisualStyleBackColor = True
    '
    'ToolStripContainer1
    '
    Me.ToolStripContainer1.BottomToolStripPanelVisible = False
    '
    'ToolStripContainer1.ContentPanel
    '
    Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(995, 485)
    Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ToolStripContainer1.LeftToolStripPanelVisible = False
    Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStripContainer1.Name = "ToolStripContainer1"
    Me.ToolStripContainer1.RightToolStripPanelVisible = False
    Me.ToolStripContainer1.Size = New System.Drawing.Size(995, 485)
    Me.ToolStripContainer1.TabIndex = 5
    Me.ToolStripContainer1.Text = "ToolStripContainer1"
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnGuardar, Me.toolStripSeparator1, Me.BtnAnadirConsulta})
    Me.ToolStrip1.Location = New System.Drawing.Point(409, 6)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(109, 25)
    Me.ToolStrip1.TabIndex = 0
    '
    'BtnNuevo
    '
    Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
    Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.BtnNuevo.Name = "BtnNuevo"
    Me.BtnNuevo.Size = New System.Drawing.Size(23, 22)
    Me.BtnNuevo.Text = "&Nuevo"
    '
    'BtnGuardar
    '
    Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
    Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.BtnGuardar.Name = "BtnGuardar"
    Me.BtnGuardar.Size = New System.Drawing.Size(23, 22)
    Me.BtnGuardar.Text = "&Guardar"
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
    'PnlUsar
    '
    Me.PnlUsar.AutoScroll = True
    Me.PnlUsar.Location = New System.Drawing.Point(0, 34)
    Me.PnlUsar.Name = "PnlUsar"
    Me.PnlUsar.Size = New System.Drawing.Size(882, 335)
    Me.PnlUsar.TabIndex = 0
    '
    'TabUsar
    '
    Me.TabUsar.Location = New System.Drawing.Point(4, 22)
    Me.TabUsar.Name = "TabUsar"
    Me.TabUsar.Padding = New System.Windows.Forms.Padding(3)
    Me.TabUsar.Size = New System.Drawing.Size(882, 369)
    Me.TabUsar.TabIndex = 1
    Me.TabUsar.Text = "Usar informe"
    Me.TabUsar.UseVisualStyleBackColor = True
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
    'toolStripSeparator1
    '
    Me.toolStripSeparator1.Name = "toolStripSeparator1"
    Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'FormPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(995, 485)
    Me.Controls.Add(Me.Tabs)
    Me.Controls.Add(Me.ToolStripContainer1)
    Me.Name = "FormPrincipal"
    Me.Text = "Informes Supra"
    Me.Tabs.ResumeLayout(False)
    Me.TabCrear.ResumeLayout(False)
    Me.TabCrear.PerformLayout()
    Me.ToolStripContainer1.ResumeLayout(False)
    Me.ToolStripContainer1.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Tabs As TabControl
  Friend WithEvents TabCrear As TabPage
  Friend WithEvents TabUsar As TabPage
  Friend WithEvents PnlUsar As FlowLayoutPanel
  Friend WithEvents LblInforme As Label
  Friend WithEvents CbInforme As ComboBox
  Friend WithEvents ToolStripContainer1 As ToolStripContainer
  Friend WithEvents ToolStrip1 As ToolStrip
  Friend WithEvents BtnNuevo As ToolStripButton
  Friend WithEvents BtnGuardar As ToolStripButton
  Friend WithEvents toolStripSeparator1 As ToolStripSeparator
  Friend WithEvents BtnAnadirConsulta As ToolStripButton
End Class
