﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
    Me.IconosBotones = New System.Windows.Forms.ImageList(Me.components)
    Me.PnlEditar = New System.Windows.Forms.FlowLayoutPanel()
    Me.BtnEliminarInforme = New System.Windows.Forms.Button()
    Me.BtnGuardarComo = New System.Windows.Forms.Button()
    Me.BtnGuardar = New System.Windows.Forms.Button()
    Me.BtnNuevo = New System.Windows.Forms.Button()
    Me.LblInforme = New System.Windows.Forms.Label()
    Me.CbInforme = New System.Windows.Forms.ComboBox()
    Me.BtnAnadirConsulta = New System.Windows.Forms.Button()
    Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
    Me.SuspendLayout()
    '
    'IconosBotones
    '
    Me.IconosBotones.ImageStream = CType(resources.GetObject("IconosBotones.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.IconosBotones.TransparentColor = System.Drawing.Color.Transparent
    Me.IconosBotones.Images.SetKeyName(0, "if_window_new_1880.png")
    Me.IconosBotones.Images.SetKeyName(1, "if_filesave_1743.png")
    Me.IconosBotones.Images.SetKeyName(2, "if_filesaveas_1744.png")
    Me.IconosBotones.Images.SetKeyName(3, "if_button_cancel_1709.png")
    '
    'PnlEditar
    '
    Me.PnlEditar.AutoScroll = True
    Me.PnlEditar.AutoSize = True
    Me.PnlEditar.Location = New System.Drawing.Point(12, 39)
    Me.PnlEditar.MaximumSize = New System.Drawing.Size(1152, 399)
    Me.PnlEditar.Name = "PnlEditar"
    Me.PnlEditar.Size = New System.Drawing.Size(1152, 10)
    Me.PnlEditar.TabIndex = 0
    '
    'BtnEliminarInforme
    '
    Me.BtnEliminarInforme.Enabled = False
    Me.BtnEliminarInforme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEliminarInforme.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEliminarInforme.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnEliminarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnEliminarInforme.ImageIndex = 3
    Me.BtnEliminarInforme.ImageList = Me.IconosBotones
    Me.BtnEliminarInforme.Location = New System.Drawing.Point(470, 11)
    Me.BtnEliminarInforme.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnEliminarInforme.Name = "BtnEliminarInforme"
    Me.BtnEliminarInforme.Size = New System.Drawing.Size(20, 20)
    Me.BtnEliminarInforme.TabIndex = 12
    Me.ToolTips.SetToolTip(Me.BtnEliminarInforme, "Eliminar informe")
    Me.BtnEliminarInforme.UseVisualStyleBackColor = True
    '
    'BtnGuardarComo
    '
    Me.BtnGuardarComo.Enabled = False
    Me.BtnGuardarComo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnGuardarComo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnGuardarComo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnGuardarComo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnGuardarComo.ImageIndex = 2
    Me.BtnGuardarComo.ImageList = Me.IconosBotones
    Me.BtnGuardarComo.Location = New System.Drawing.Point(450, 11)
    Me.BtnGuardarComo.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnGuardarComo.Name = "BtnGuardarComo"
    Me.BtnGuardarComo.Size = New System.Drawing.Size(20, 20)
    Me.BtnGuardarComo.TabIndex = 11
    Me.ToolTips.SetToolTip(Me.BtnGuardarComo, "Guardar informe como...")
    Me.BtnGuardarComo.UseVisualStyleBackColor = True
    '
    'BtnGuardar
    '
    Me.BtnGuardar.Enabled = False
    Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnGuardar.ImageIndex = 1
    Me.BtnGuardar.ImageList = Me.IconosBotones
    Me.BtnGuardar.Location = New System.Drawing.Point(430, 11)
    Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnGuardar.Name = "BtnGuardar"
    Me.BtnGuardar.Size = New System.Drawing.Size(20, 20)
    Me.BtnGuardar.TabIndex = 10
    Me.ToolTips.SetToolTip(Me.BtnGuardar, "Guardar informe")
    Me.BtnGuardar.UseVisualStyleBackColor = True
    '
    'BtnNuevo
    '
    Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnNuevo.ImageIndex = 0
    Me.BtnNuevo.ImageList = Me.IconosBotones
    Me.BtnNuevo.Location = New System.Drawing.Point(410, 11)
    Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnNuevo.Name = "BtnNuevo"
    Me.BtnNuevo.Size = New System.Drawing.Size(20, 20)
    Me.BtnNuevo.TabIndex = 9
    Me.ToolTips.SetToolTip(Me.BtnNuevo, "Nuevo informe...")
    Me.BtnNuevo.UseVisualStyleBackColor = True
    '
    'LblInforme
    '
    Me.LblInforme.AutoSize = True
    Me.LblInforme.Location = New System.Drawing.Point(12, 15)
    Me.LblInforme.Name = "LblInforme"
    Me.LblInforme.Size = New System.Drawing.Size(45, 13)
    Me.LblInforme.TabIndex = 8
    Me.LblInforme.Text = "Informe:"
    '
    'CbInforme
    '
    Me.CbInforme.FormattingEnabled = True
    Me.CbInforme.Location = New System.Drawing.Point(63, 12)
    Me.CbInforme.Name = "CbInforme"
    Me.CbInforme.Size = New System.Drawing.Size(344, 21)
    Me.CbInforme.TabIndex = 7
    '
    'BtnAnadirConsulta
    '
    Me.BtnAnadirConsulta.Enabled = False
    Me.BtnAnadirConsulta.Location = New System.Drawing.Point(12, 55)
    Me.BtnAnadirConsulta.Name = "BtnAnadirConsulta"
    Me.BtnAnadirConsulta.Size = New System.Drawing.Size(90, 23)
    Me.BtnAnadirConsulta.TabIndex = 13
    Me.BtnAnadirConsulta.Text = "Añadir consulta"
    Me.BtnAnadirConsulta.UseVisualStyleBackColor = True
    '
    'FormPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1184, 514)
    Me.Controls.Add(Me.BtnAnadirConsulta)
    Me.Controls.Add(Me.BtnEliminarInforme)
    Me.Controls.Add(Me.PnlEditar)
    Me.Controls.Add(Me.BtnGuardarComo)
    Me.Controls.Add(Me.BtnGuardar)
    Me.Controls.Add(Me.BtnNuevo)
    Me.Controls.Add(Me.LblInforme)
    Me.Controls.Add(Me.CbInforme)
    Me.Name = "FormPrincipal"
    Me.Text = "Informes Supra"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PnlEditar As FlowLayoutPanel
  Friend WithEvents IconosBotones As ImageList
  Friend WithEvents BtnEliminarInforme As Button
  Friend WithEvents BtnGuardarComo As Button
  Friend WithEvents BtnGuardar As Button
  Friend WithEvents BtnNuevo As Button
  Friend WithEvents LblInforme As Label
  Friend WithEvents CbInforme As ComboBox
  Friend WithEvents BtnAnadirConsulta As Button
  Friend WithEvents ToolTips As ToolTip
End Class
