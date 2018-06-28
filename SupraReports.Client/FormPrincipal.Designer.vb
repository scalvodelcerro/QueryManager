<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
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
    Me.InformeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.BtnAnadirConsulta = New System.Windows.Forms.Button()
    Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
    Me.BtnEjecutar = New System.Windows.Forms.Button()
    Me.BtnConfiguracion = New System.Windows.Forms.Button()
    Me.BtnProgramar = New System.Windows.Forms.Button()
    Me.IconoNotificacion = New System.Windows.Forms.NotifyIcon(Me.components)
    Me.MenuIconoNotificacion = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.MenuIconoNotificacionCancelarProgramaciones = New System.Windows.Forms.ToolStripMenuItem()
    Me.TimerSegundo = New System.Windows.Forms.Timer(Me.components)
    Me.BtnEjecutarProgramaciones = New System.Windows.Forms.Button()
    Me.LblProyecto = New System.Windows.Forms.Label()
    Me.CbProyecto = New System.Windows.Forms.ComboBox()
    Me.ProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.PbEjecutar = New System.Windows.Forms.ProgressBar()
    CType(Me.InformeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuIconoNotificacion.SuspendLayout()
    CType(Me.ProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'IconosBotones
    '
    Me.IconosBotones.ImageStream = CType(resources.GetObject("IconosBotones.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.IconosBotones.TransparentColor = System.Drawing.Color.Transparent
    Me.IconosBotones.Images.SetKeyName(0, "if_window_new_1880.png")
    Me.IconosBotones.Images.SetKeyName(1, "if_filesave_1743.png")
    Me.IconosBotones.Images.SetKeyName(2, "if_filesaveas_1744.png")
    Me.IconosBotones.Images.SetKeyName(3, "if_cancel_1712.png")
    Me.IconosBotones.Images.SetKeyName(4, "if_player_play_1825.png")
    Me.IconosBotones.Images.SetKeyName(5, "if_clock_1233 .png")
    Me.IconosBotones.Images.SetKeyName(6, "if_clock_play_1233 .png")
    Me.IconosBotones.Images.SetKeyName(7, "if_edit_add_1727.png")
    Me.IconosBotones.Images.SetKeyName(8, "if_kservices_1385.png")
    '
    'PnlEditar
    '
    Me.PnlEditar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PnlEditar.AutoScroll = True
    Me.PnlEditar.AutoSize = True
    Me.PnlEditar.Location = New System.Drawing.Point(16, 66)
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
    Me.BtnEliminarInforme.ImageIndex = 3
    Me.BtnEliminarInforme.ImageList = Me.IconosBotones
    Me.BtnEliminarInforme.Location = New System.Drawing.Point(489, 37)
    Me.BtnEliminarInforme.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnEliminarInforme.Name = "BtnEliminarInforme"
    Me.BtnEliminarInforme.Size = New System.Drawing.Size(24, 24)
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
    Me.BtnGuardarComo.ImageIndex = 2
    Me.BtnGuardarComo.ImageList = Me.IconosBotones
    Me.BtnGuardarComo.Location = New System.Drawing.Point(465, 37)
    Me.BtnGuardarComo.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnGuardarComo.Name = "BtnGuardarComo"
    Me.BtnGuardarComo.Size = New System.Drawing.Size(24, 24)
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
    Me.BtnGuardar.ImageIndex = 1
    Me.BtnGuardar.ImageList = Me.IconosBotones
    Me.BtnGuardar.Location = New System.Drawing.Point(441, 37)
    Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnGuardar.Name = "BtnGuardar"
    Me.BtnGuardar.Size = New System.Drawing.Size(24, 24)
    Me.BtnGuardar.TabIndex = 10
    Me.ToolTips.SetToolTip(Me.BtnGuardar, "Guardar informe")
    Me.BtnGuardar.UseVisualStyleBackColor = True
    '
    'BtnNuevo
    '
    Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnNuevo.ImageIndex = 0
    Me.BtnNuevo.ImageList = Me.IconosBotones
    Me.BtnNuevo.Location = New System.Drawing.Point(417, 37)
    Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnNuevo.Name = "BtnNuevo"
    Me.BtnNuevo.Size = New System.Drawing.Size(24, 24)
    Me.BtnNuevo.TabIndex = 9
    Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.ToolTips.SetToolTip(Me.BtnNuevo, "Nuevo informe...")
    Me.BtnNuevo.UseVisualStyleBackColor = True
    '
    'LblInforme
    '
    Me.LblInforme.AutoSize = True
    Me.LblInforme.Location = New System.Drawing.Point(12, 42)
    Me.LblInforme.Name = "LblInforme"
    Me.LblInforme.Size = New System.Drawing.Size(45, 13)
    Me.LblInforme.TabIndex = 8
    Me.LblInforme.Text = "Informe:"
    '
    'CbInforme
    '
    Me.CbInforme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    Me.CbInforme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.CbInforme.DataSource = Me.InformeBindingSource
    Me.CbInforme.DisplayMember = "Nombre"
    Me.CbInforme.FormattingEnabled = True
    Me.CbInforme.Location = New System.Drawing.Point(70, 39)
    Me.CbInforme.Name = "CbInforme"
    Me.CbInforme.Size = New System.Drawing.Size(344, 21)
    Me.CbInforme.TabIndex = 7
    Me.CbInforme.ValueMember = "Id"
    '
    'InformeBindingSource
    '
    Me.InformeBindingSource.DataSource = GetType(SupraReports.Model.Informe)
    '
    'BtnAnadirConsulta
    '
    Me.BtnAnadirConsulta.Enabled = False
    Me.BtnAnadirConsulta.ImageIndex = 7
    Me.BtnAnadirConsulta.ImageList = Me.IconosBotones
    Me.BtnAnadirConsulta.Location = New System.Drawing.Point(12, 82)
    Me.BtnAnadirConsulta.Name = "BtnAnadirConsulta"
    Me.BtnAnadirConsulta.Size = New System.Drawing.Size(115, 26)
    Me.BtnAnadirConsulta.TabIndex = 13
    Me.BtnAnadirConsulta.Text = "Añadir consulta"
    Me.BtnAnadirConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.BtnAnadirConsulta.UseVisualStyleBackColor = True
    '
    'BtnEjecutar
    '
    Me.BtnEjecutar.Enabled = False
    Me.BtnEjecutar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEjecutar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEjecutar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnEjecutar.ImageIndex = 4
    Me.BtnEjecutar.ImageList = Me.IconosBotones
    Me.BtnEjecutar.Location = New System.Drawing.Point(523, 37)
    Me.BtnEjecutar.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
    Me.BtnEjecutar.Name = "BtnEjecutar"
    Me.BtnEjecutar.Size = New System.Drawing.Size(24, 24)
    Me.BtnEjecutar.TabIndex = 14
    Me.ToolTips.SetToolTip(Me.BtnEjecutar, "Ejecutar informe")
    Me.BtnEjecutar.UseVisualStyleBackColor = True
    '
    'BtnConfiguracion
    '
    Me.BtnConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnConfiguracion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnConfiguracion.ImageIndex = 8
    Me.BtnConfiguracion.ImageList = Me.IconosBotones
    Me.BtnConfiguracion.Location = New System.Drawing.Point(1151, 10)
    Me.BtnConfiguracion.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnConfiguracion.Name = "BtnConfiguracion"
    Me.BtnConfiguracion.Size = New System.Drawing.Size(24, 24)
    Me.BtnConfiguracion.TabIndex = 17
    Me.ToolTips.SetToolTip(Me.BtnConfiguracion, "Configuración...")
    Me.BtnConfiguracion.UseVisualStyleBackColor = True
    '
    'BtnProgramar
    '
    Me.BtnProgramar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnProgramar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnProgramar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnProgramar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnProgramar.ImageIndex = 5
    Me.BtnProgramar.ImageList = Me.IconosBotones
    Me.BtnProgramar.Location = New System.Drawing.Point(887, 444)
    Me.BtnProgramar.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnProgramar.Name = "BtnProgramar"
    Me.BtnProgramar.Size = New System.Drawing.Size(141, 26)
    Me.BtnProgramar.TabIndex = 15
    Me.BtnProgramar.Text = "Programar informes..."
    Me.BtnProgramar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.BtnProgramar.UseVisualStyleBackColor = True
    '
    'IconoNotificacion
    '
    Me.IconoNotificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
    Me.IconoNotificacion.BalloonTipText = "Minimizado en el área de notificación"
    Me.IconoNotificacion.BalloonTipTitle = "Informes Supra "
    Me.IconoNotificacion.ContextMenuStrip = Me.MenuIconoNotificacion
    Me.IconoNotificacion.Icon = CType(resources.GetObject("IconoNotificacion.Icon"), System.Drawing.Icon)
    Me.IconoNotificacion.Text = "Informes Supra"
    '
    'MenuIconoNotificacion
    '
    Me.MenuIconoNotificacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuIconoNotificacionCancelarProgramaciones})
    Me.MenuIconoNotificacion.Name = "MenuIconoNotificacion"
    Me.MenuIconoNotificacion.Size = New System.Drawing.Size(210, 26)
    '
    'MenuIconoNotificacionCancelarProgramaciones
    '
    Me.MenuIconoNotificacionCancelarProgramaciones.Name = "MenuIconoNotificacionCancelarProgramaciones"
    Me.MenuIconoNotificacionCancelarProgramaciones.Size = New System.Drawing.Size(209, 22)
    Me.MenuIconoNotificacionCancelarProgramaciones.Text = "Cancelar programaciones"
    '
    'TimerSegundo
    '
    Me.TimerSegundo.Interval = 1000
    '
    'BtnEjecutarProgramaciones
    '
    Me.BtnEjecutarProgramaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnEjecutarProgramaciones.ImageIndex = 6
    Me.BtnEjecutarProgramaciones.ImageList = Me.IconosBotones
    Me.BtnEjecutarProgramaciones.Location = New System.Drawing.Point(1031, 444)
    Me.BtnEjecutarProgramaciones.Name = "BtnEjecutarProgramaciones"
    Me.BtnEjecutarProgramaciones.Size = New System.Drawing.Size(141, 26)
    Me.BtnEjecutarProgramaciones.TabIndex = 16
    Me.BtnEjecutarProgramaciones.Text = "Lanzar programaciones"
    Me.BtnEjecutarProgramaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.BtnEjecutarProgramaciones.UseVisualStyleBackColor = True
    '
    'LblProyecto
    '
    Me.LblProyecto.AutoSize = True
    Me.LblProyecto.Location = New System.Drawing.Point(12, 15)
    Me.LblProyecto.Name = "LblProyecto"
    Me.LblProyecto.Size = New System.Drawing.Size(52, 13)
    Me.LblProyecto.TabIndex = 19
    Me.LblProyecto.Text = "Proyecto:"
    '
    'CbProyecto
    '
    Me.CbProyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    Me.CbProyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.CbProyecto.DataSource = Me.ProyectoBindingSource
    Me.CbProyecto.DisplayMember = "Nombre"
    Me.CbProyecto.FormattingEnabled = True
    Me.CbProyecto.Location = New System.Drawing.Point(70, 12)
    Me.CbProyecto.Name = "CbProyecto"
    Me.CbProyecto.Size = New System.Drawing.Size(344, 21)
    Me.CbProyecto.TabIndex = 18
    Me.CbProyecto.ValueMember = "Id"
    '
    'ProyectoBindingSource
    '
    Me.ProyectoBindingSource.DataSource = GetType(SupraReports.Model.Proyecto)
    '
    'PbEjecutar
    '
    Me.PbEjecutar.Location = New System.Drawing.Point(550, 43)
    Me.PbEjecutar.Name = "PbEjecutar"
    Me.PbEjecutar.Size = New System.Drawing.Size(120, 12)
    Me.PbEjecutar.TabIndex = 20
    Me.PbEjecutar.Visible = False
    '
    'FormPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1184, 481)
    Me.Controls.Add(Me.PbEjecutar)
    Me.Controls.Add(Me.LblProyecto)
    Me.Controls.Add(Me.CbProyecto)
    Me.Controls.Add(Me.BtnConfiguracion)
    Me.Controls.Add(Me.BtnEjecutarProgramaciones)
    Me.Controls.Add(Me.BtnProgramar)
    Me.Controls.Add(Me.BtnEjecutar)
    Me.Controls.Add(Me.BtnAnadirConsulta)
    Me.Controls.Add(Me.BtnEliminarInforme)
    Me.Controls.Add(Me.PnlEditar)
    Me.Controls.Add(Me.BtnGuardarComo)
    Me.Controls.Add(Me.BtnGuardar)
    Me.Controls.Add(Me.BtnNuevo)
    Me.Controls.Add(Me.LblInforme)
    Me.Controls.Add(Me.CbInforme)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "FormPrincipal"
    Me.Text = "N.E.S.S.I.E. - Navegador del Entorno Supra con Salida de Informes Excel"
    CType(Me.InformeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuIconoNotificacion.ResumeLayout(False)
    CType(Me.ProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents BtnEjecutar As Button
  Friend WithEvents BtnProgramar As Button
  Friend WithEvents IconoNotificacion As NotifyIcon
  Friend WithEvents TimerSegundo As Timer
  Friend WithEvents BtnEjecutarProgramaciones As Button
  Friend WithEvents MenuIconoNotificacion As ContextMenuStrip
  Friend WithEvents MenuIconoNotificacionCancelarProgramaciones As ToolStripMenuItem
  Friend WithEvents BtnConfiguracion As Button
  Friend WithEvents InformeBindingSource As BindingSource
  Friend WithEvents LblProyecto As Label
  Friend WithEvents CbProyecto As ComboBox
  Friend WithEvents ProyectoBindingSource As BindingSource
  Friend WithEvents PbEjecutar As ProgressBar
End Class
