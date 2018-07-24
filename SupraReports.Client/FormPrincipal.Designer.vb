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
    Me.BtnNuevoInforme = New System.Windows.Forms.Button()
    Me.LblInforme = New System.Windows.Forms.Label()
    Me.CbInforme = New System.Windows.Forms.ComboBox()
    Me.InformeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.BtnAnadirConsulta = New System.Windows.Forms.Button()
    Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
    Me.BtnEjecutar = New System.Windows.Forms.Button()
    Me.BtnConfigurarInforme = New System.Windows.Forms.Button()
    Me.BtnNuevoProyecto = New System.Windows.Forms.Button()
    Me.BtnConfigurarProyecto = New System.Windows.Forms.Button()
    Me.BtnEliminarProyecto = New System.Windows.Forms.Button()
    Me.IconosBotonesProgramar = New System.Windows.Forms.ImageList(Me.components)
    Me.IconoNotificacion = New System.Windows.Forms.NotifyIcon(Me.components)
    Me.TimerSegundo = New System.Windows.Forms.Timer(Me.components)
    Me.LblProyecto = New System.Windows.Forms.Label()
    Me.CbProyecto = New System.Windows.Forms.ComboBox()
    Me.ProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.PbEjecutar = New System.Windows.Forms.ProgressBar()
    Me.GbConsultas = New System.Windows.Forms.GroupBox()
    Me.BarraMenus = New System.Windows.Forms.MenuStrip()
    Me.ConfiguracionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.RutaPorDefectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ProgramarInformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.VerProgramacionesHistóricasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.VerAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ImgNessie = New System.Windows.Forms.PictureBox()
    CType(Me.InformeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GbConsultas.SuspendLayout()
    Me.BarraMenus.SuspendLayout()
    CType(Me.ImgNessie, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.PnlEditar.Location = New System.Drawing.Point(3, 16)
    Me.PnlEditar.Margin = New System.Windows.Forms.Padding(0)
    Me.PnlEditar.Name = "PnlEditar"
    Me.PnlEditar.Size = New System.Drawing.Size(714, 190)
    Me.PnlEditar.TabIndex = 0
    '
    'BtnEliminarInforme
    '
    Me.BtnEliminarInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnEliminarInforme.Enabled = False
    Me.BtnEliminarInforme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEliminarInforme.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEliminarInforme.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnEliminarInforme.ImageIndex = 3
    Me.BtnEliminarInforme.ImageList = Me.IconosBotones
    Me.BtnEliminarInforme.Location = New System.Drawing.Point(541, 70)
    Me.BtnEliminarInforme.Margin = New System.Windows.Forms.Padding(1)
    Me.BtnEliminarInforme.Name = "BtnEliminarInforme"
    Me.BtnEliminarInforme.Size = New System.Drawing.Size(24, 24)
    Me.BtnEliminarInforme.TabIndex = 12
    Me.ToolTips.SetToolTip(Me.BtnEliminarInforme, "Eliminar informe")
    Me.BtnEliminarInforme.UseVisualStyleBackColor = True
    '
    'BtnGuardarComo
    '
    Me.BtnGuardarComo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnGuardarComo.Enabled = False
    Me.BtnGuardarComo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnGuardarComo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnGuardarComo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnGuardarComo.ImageIndex = 2
    Me.BtnGuardarComo.ImageList = Me.IconosBotones
    Me.BtnGuardarComo.Location = New System.Drawing.Point(515, 70)
    Me.BtnGuardarComo.Margin = New System.Windows.Forms.Padding(1)
    Me.BtnGuardarComo.Name = "BtnGuardarComo"
    Me.BtnGuardarComo.Size = New System.Drawing.Size(24, 24)
    Me.BtnGuardarComo.TabIndex = 11
    Me.ToolTips.SetToolTip(Me.BtnGuardarComo, "Guardar informe como...")
    Me.BtnGuardarComo.UseVisualStyleBackColor = True
    '
    'BtnGuardar
    '
    Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnGuardar.Enabled = False
    Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnGuardar.ImageIndex = 1
    Me.BtnGuardar.ImageList = Me.IconosBotones
    Me.BtnGuardar.Location = New System.Drawing.Point(489, 70)
    Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(1)
    Me.BtnGuardar.Name = "BtnGuardar"
    Me.BtnGuardar.Size = New System.Drawing.Size(24, 24)
    Me.BtnGuardar.TabIndex = 10
    Me.ToolTips.SetToolTip(Me.BtnGuardar, "Guardar informe")
    Me.BtnGuardar.UseVisualStyleBackColor = True
    '
    'BtnNuevoInforme
    '
    Me.BtnNuevoInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnNuevoInforme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnNuevoInforme.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnNuevoInforme.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnNuevoInforme.ImageIndex = 0
    Me.BtnNuevoInforme.ImageList = Me.IconosBotones
    Me.BtnNuevoInforme.Location = New System.Drawing.Point(463, 70)
    Me.BtnNuevoInforme.Margin = New System.Windows.Forms.Padding(1)
    Me.BtnNuevoInforme.Name = "BtnNuevoInforme"
    Me.BtnNuevoInforme.Size = New System.Drawing.Size(24, 24)
    Me.BtnNuevoInforme.TabIndex = 9
    Me.BtnNuevoInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.ToolTips.SetToolTip(Me.BtnNuevoInforme, "Nuevo informe...")
    Me.BtnNuevoInforme.UseVisualStyleBackColor = True
    '
    'LblInforme
    '
    Me.LblInforme.AutoSize = True
    Me.LblInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblInforme.Location = New System.Drawing.Point(12, 73)
    Me.LblInforme.Name = "LblInforme"
    Me.LblInforme.Size = New System.Drawing.Size(82, 17)
    Me.LblInforme.TabIndex = 8
    Me.LblInforme.Text = "INFORME:"
    '
    'CbInforme
    '
    Me.CbInforme.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CbInforme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    Me.CbInforme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.CbInforme.DataSource = Me.InformeBindingSource
    Me.CbInforme.DisplayMember = "Nombre"
    Me.CbInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CbInforme.FormattingEnabled = True
    Me.CbInforme.Location = New System.Drawing.Point(116, 70)
    Me.CbInforme.Name = "CbInforme"
    Me.CbInforme.Size = New System.Drawing.Size(344, 24)
    Me.CbInforme.TabIndex = 7
    Me.CbInforme.ValueMember = "Id"
    '
    'InformeBindingSource
    '
    Me.InformeBindingSource.DataSource = GetType(SupraReports.Model.Informe)
    '
    'BtnAnadirConsulta
    '
    Me.BtnAnadirConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.BtnAnadirConsulta.Enabled = False
    Me.BtnAnadirConsulta.ImageIndex = 7
    Me.BtnAnadirConsulta.ImageList = Me.IconosBotones
    Me.BtnAnadirConsulta.Location = New System.Drawing.Point(6, 206)
    Me.BtnAnadirConsulta.Margin = New System.Windows.Forms.Padding(0)
    Me.BtnAnadirConsulta.Name = "BtnAnadirConsulta"
    Me.BtnAnadirConsulta.Size = New System.Drawing.Size(115, 26)
    Me.BtnAnadirConsulta.TabIndex = 13
    Me.BtnAnadirConsulta.Text = "Añadir consulta"
    Me.BtnAnadirConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.BtnAnadirConsulta.UseVisualStyleBackColor = True
    '
    'BtnEjecutar
    '
    Me.BtnEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnEjecutar.Enabled = False
    Me.BtnEjecutar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEjecutar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEjecutar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnEjecutar.ImageIndex = 4
    Me.BtnEjecutar.ImageList = Me.IconosBotones
    Me.BtnEjecutar.Location = New System.Drawing.Point(612, 70)
    Me.BtnEjecutar.Margin = New System.Windows.Forms.Padding(10, 2, 2, 2)
    Me.BtnEjecutar.Name = "BtnEjecutar"
    Me.BtnEjecutar.Size = New System.Drawing.Size(24, 24)
    Me.BtnEjecutar.TabIndex = 14
    Me.ToolTips.SetToolTip(Me.BtnEjecutar, "Ejecutar informe")
    Me.BtnEjecutar.UseVisualStyleBackColor = True
    '
    'BtnConfigurarInforme
    '
    Me.BtnConfigurarInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnConfigurarInforme.Enabled = False
    Me.BtnConfigurarInforme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnConfigurarInforme.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnConfigurarInforme.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnConfigurarInforme.ImageIndex = 8
    Me.BtnConfigurarInforme.ImageList = Me.IconosBotones
    Me.BtnConfigurarInforme.Location = New System.Drawing.Point(576, 70)
    Me.BtnConfigurarInforme.Margin = New System.Windows.Forms.Padding(10, 2, 2, 2)
    Me.BtnConfigurarInforme.Name = "BtnConfigurarInforme"
    Me.BtnConfigurarInforme.Size = New System.Drawing.Size(24, 24)
    Me.BtnConfigurarInforme.TabIndex = 22
    Me.ToolTips.SetToolTip(Me.BtnConfigurarInforme, "Configuración del informe...")
    Me.BtnConfigurarInforme.UseVisualStyleBackColor = True
    '
    'BtnNuevoProyecto
    '
    Me.BtnNuevoProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnNuevoProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnNuevoProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnNuevoProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnNuevoProyecto.ImageIndex = 0
    Me.BtnNuevoProyecto.ImageList = Me.IconosBotones
    Me.BtnNuevoProyecto.Location = New System.Drawing.Point(463, 40)
    Me.BtnNuevoProyecto.Margin = New System.Windows.Forms.Padding(2)
    Me.BtnNuevoProyecto.Name = "BtnNuevoProyecto"
    Me.BtnNuevoProyecto.Size = New System.Drawing.Size(24, 24)
    Me.BtnNuevoProyecto.TabIndex = 25
    Me.BtnNuevoProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.ToolTips.SetToolTip(Me.BtnNuevoProyecto, "Nuevo proyecto...")
    Me.BtnNuevoProyecto.UseVisualStyleBackColor = True
    '
    'BtnConfigurarProyecto
    '
    Me.BtnConfigurarProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnConfigurarProyecto.Enabled = False
    Me.BtnConfigurarProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnConfigurarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnConfigurarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnConfigurarProyecto.ImageIndex = 8
    Me.BtnConfigurarProyecto.ImageList = Me.IconosBotones
    Me.BtnConfigurarProyecto.Location = New System.Drawing.Point(576, 40)
    Me.BtnConfigurarProyecto.Margin = New System.Windows.Forms.Padding(10, 2, 2, 2)
    Me.BtnConfigurarProyecto.Name = "BtnConfigurarProyecto"
    Me.BtnConfigurarProyecto.Size = New System.Drawing.Size(24, 24)
    Me.BtnConfigurarProyecto.TabIndex = 26
    Me.ToolTips.SetToolTip(Me.BtnConfigurarProyecto, "Configuración del proyecto...")
    Me.BtnConfigurarProyecto.UseVisualStyleBackColor = True
    '
    'BtnEliminarProyecto
    '
    Me.BtnEliminarProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnEliminarProyecto.Enabled = False
    Me.BtnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEliminarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEliminarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnEliminarProyecto.ImageIndex = 3
    Me.BtnEliminarProyecto.ImageList = Me.IconosBotones
    Me.BtnEliminarProyecto.Location = New System.Drawing.Point(541, 40)
    Me.BtnEliminarProyecto.Margin = New System.Windows.Forms.Padding(1)
    Me.BtnEliminarProyecto.Name = "BtnEliminarProyecto"
    Me.BtnEliminarProyecto.Size = New System.Drawing.Size(24, 24)
    Me.BtnEliminarProyecto.TabIndex = 27
    Me.ToolTips.SetToolTip(Me.BtnEliminarProyecto, "Eliminar proyecto")
    Me.BtnEliminarProyecto.UseVisualStyleBackColor = True
    '
    'IconosBotonesProgramar
    '
    Me.IconosBotonesProgramar.ImageStream = CType(resources.GetObject("IconosBotonesProgramar.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.IconosBotonesProgramar.TransparentColor = System.Drawing.Color.Transparent
    Me.IconosBotonesProgramar.Images.SetKeyName(0, "if_clock_1233 .png")
    Me.IconosBotonesProgramar.Images.SetKeyName(1, "if_clock_play_1233 .png")
    '
    'IconoNotificacion
    '
    Me.IconoNotificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
    Me.IconoNotificacion.BalloonTipText = "Minimizado en el área de notificación"
    Me.IconoNotificacion.BalloonTipTitle = "Informes Supra "
    Me.IconoNotificacion.Icon = CType(resources.GetObject("IconoNotificacion.Icon"), System.Drawing.Icon)
    Me.IconoNotificacion.Text = "Informes Supra"
    Me.IconoNotificacion.Visible = True
    '
    'TimerSegundo
    '
    Me.TimerSegundo.Interval = 1000
    '
    'LblProyecto
    '
    Me.LblProyecto.AutoSize = True
    Me.LblProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblProyecto.Location = New System.Drawing.Point(12, 43)
    Me.LblProyecto.Name = "LblProyecto"
    Me.LblProyecto.Size = New System.Drawing.Size(98, 17)
    Me.LblProyecto.TabIndex = 19
    Me.LblProyecto.Text = "PROYECTO:"
    '
    'CbProyecto
    '
    Me.CbProyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CbProyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    Me.CbProyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.CbProyecto.DataSource = Me.ProyectoBindingSource
    Me.CbProyecto.DisplayMember = "Nombre"
    Me.CbProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CbProyecto.FormattingEnabled = True
    Me.CbProyecto.Location = New System.Drawing.Point(116, 40)
    Me.CbProyecto.Name = "CbProyecto"
    Me.CbProyecto.Size = New System.Drawing.Size(344, 24)
    Me.CbProyecto.TabIndex = 18
    Me.CbProyecto.ValueMember = "Id"
    '
    'ProyectoBindingSource
    '
    Me.ProyectoBindingSource.DataSource = GetType(SupraReports.Model.Proyecto)
    '
    'PbEjecutar
    '
    Me.PbEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PbEjecutar.Location = New System.Drawing.Point(649, 95)
    Me.PbEjecutar.Name = "PbEjecutar"
    Me.PbEjecutar.Size = New System.Drawing.Size(83, 10)
    Me.PbEjecutar.TabIndex = 20
    Me.PbEjecutar.Visible = False
    '
    'GbConsultas
    '
    Me.GbConsultas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GbConsultas.BackColor = System.Drawing.SystemColors.ControlLight
    Me.GbConsultas.Controls.Add(Me.PnlEditar)
    Me.GbConsultas.Controls.Add(Me.BtnAnadirConsulta)
    Me.GbConsultas.Location = New System.Drawing.Point(12, 111)
    Me.GbConsultas.Name = "GbConsultas"
    Me.GbConsultas.Size = New System.Drawing.Size(720, 238)
    Me.GbConsultas.TabIndex = 21
    Me.GbConsultas.TabStop = False
    Me.GbConsultas.Text = "Consultas"
    '
    'BarraMenus
    '
    Me.BarraMenus.BackColor = System.Drawing.SystemColors.MenuBar
    Me.BarraMenus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionMenuItem, Me.AyudaToolStripMenuItem})
    Me.BarraMenus.Location = New System.Drawing.Point(0, 0)
    Me.BarraMenus.Name = "BarraMenus"
    Me.BarraMenus.Size = New System.Drawing.Size(744, 24)
    Me.BarraMenus.TabIndex = 23
    Me.BarraMenus.Text = "MenuStrip1"
    '
    'ConfiguracionMenuItem
    '
    Me.ConfiguracionMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RutaPorDefectoToolStripMenuItem, Me.ProgramarInformesToolStripMenuItem, Me.VerProgramacionesHistóricasToolStripMenuItem})
    Me.ConfiguracionMenuItem.Name = "ConfiguracionMenuItem"
    Me.ConfiguracionMenuItem.Size = New System.Drawing.Size(95, 20)
    Me.ConfiguracionMenuItem.Text = "Configuración"
    '
    'RutaPorDefectoToolStripMenuItem
    '
    Me.RutaPorDefectoToolStripMenuItem.Name = "RutaPorDefectoToolStripMenuItem"
    Me.RutaPorDefectoToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
    Me.RutaPorDefectoToolStripMenuItem.Text = "Ruta por defecto"
    '
    'ProgramarInformesToolStripMenuItem
    '
    Me.ProgramarInformesToolStripMenuItem.Name = "ProgramarInformesToolStripMenuItem"
    Me.ProgramarInformesToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
    Me.ProgramarInformesToolStripMenuItem.Text = "Programar informes"
    '
    'VerProgramacionesHistóricasToolStripMenuItem
    '
    Me.VerProgramacionesHistóricasToolStripMenuItem.Name = "VerProgramacionesHistóricasToolStripMenuItem"
    Me.VerProgramacionesHistóricasToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
    Me.VerProgramacionesHistóricasToolStripMenuItem.Text = "Ver histórico de programaciones"
    '
    'AyudaToolStripMenuItem
    '
    Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerAyudaToolStripMenuItem, Me.ToolStripSeparator1, Me.AcercaDeToolStripMenuItem})
    Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
    Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
    Me.AyudaToolStripMenuItem.Text = "Ayuda"
    '
    'VerAyudaToolStripMenuItem
    '
    Me.VerAyudaToolStripMenuItem.Enabled = False
    Me.VerAyudaToolStripMenuItem.Name = "VerAyudaToolStripMenuItem"
    Me.VerAyudaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
    Me.VerAyudaToolStripMenuItem.Text = "Ver Ayuda"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
    '
    'AcercaDeToolStripMenuItem
    '
    Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
    Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
    Me.AcercaDeToolStripMenuItem.Text = "Acerca de NESSIE"
    '
    'ImgNessie
    '
    Me.ImgNessie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ImgNessie.Image = Global.SupraReports.Client.My.Resources.Resources.nessie_512
    Me.ImgNessie.Location = New System.Drawing.Point(658, 31)
    Me.ImgNessie.Name = "ImgNessie"
    Me.ImgNessie.Size = New System.Drawing.Size(64, 58)
    Me.ImgNessie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.ImgNessie.TabIndex = 24
    Me.ImgNessie.TabStop = False
    '
    'FormPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(744, 361)
    Me.Controls.Add(Me.BtnEliminarProyecto)
    Me.Controls.Add(Me.BtnConfigurarProyecto)
    Me.Controls.Add(Me.BtnNuevoProyecto)
    Me.Controls.Add(Me.ImgNessie)
    Me.Controls.Add(Me.BarraMenus)
    Me.Controls.Add(Me.BtnConfigurarInforme)
    Me.Controls.Add(Me.GbConsultas)
    Me.Controls.Add(Me.PbEjecutar)
    Me.Controls.Add(Me.LblProyecto)
    Me.Controls.Add(Me.CbProyecto)
    Me.Controls.Add(Me.BtnEjecutar)
    Me.Controls.Add(Me.BtnEliminarInforme)
    Me.Controls.Add(Me.BtnGuardarComo)
    Me.Controls.Add(Me.BtnGuardar)
    Me.Controls.Add(Me.BtnNuevoInforme)
    Me.Controls.Add(Me.LblInforme)
    Me.Controls.Add(Me.CbInforme)
    Me.DoubleBuffered = True
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.BarraMenus
    Me.MinimumSize = New System.Drawing.Size(760, 400)
    Me.Name = "FormPrincipal"
    Me.Text = "NESSIE"
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    CType(Me.InformeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GbConsultas.ResumeLayout(False)
    Me.BarraMenus.ResumeLayout(False)
    Me.BarraMenus.PerformLayout()
    CType(Me.ImgNessie, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PnlEditar As FlowLayoutPanel
    Friend WithEvents IconosBotones As ImageList
    Friend WithEvents BtnEliminarInforme As Button
    Friend WithEvents BtnGuardarComo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevoInforme As Button
    Friend WithEvents LblInforme As Label
    Friend WithEvents CbInforme As ComboBox
    Friend WithEvents BtnAnadirConsulta As Button
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents BtnEjecutar As Button
    Friend WithEvents IconoNotificacion As NotifyIcon
    Friend WithEvents TimerSegundo As Timer
    Friend WithEvents InformeBindingSource As BindingSource
    Friend WithEvents LblProyecto As Label
    Friend WithEvents CbProyecto As ComboBox
    Friend WithEvents ProyectoBindingSource As BindingSource
    Friend WithEvents PbEjecutar As ProgressBar
    Friend WithEvents GbConsultas As System.Windows.Forms.GroupBox
    Friend WithEvents BtnConfigurarInforme As System.Windows.Forms.Button
    Friend WithEvents BarraMenus As System.Windows.Forms.MenuStrip
    Friend WithEvents ConfiguracionMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImgNessie As System.Windows.Forms.PictureBox
    Friend WithEvents BtnNuevoProyecto As System.Windows.Forms.Button
    Friend WithEvents BtnConfigurarProyecto As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarProyecto As System.Windows.Forms.Button
    Friend WithEvents IconosBotonesProgramar As System.Windows.Forms.ImageList
    Friend WithEvents RutaPorDefectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramarInformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerProgramacionesHistóricasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
