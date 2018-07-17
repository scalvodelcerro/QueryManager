<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarConsultaUserControl
  Inherits System.Windows.Forms.UserControl

  'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarConsultaUserControl))
        Me.PnlParametros = New System.Windows.Forms.FlowLayoutPanel()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.BtnEliminarConsulta = New System.Windows.Forms.Button()
        Me.IconosBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnPrevisualizar = New System.Windows.Forms.Button()
        Me.CbHabilitada = New System.Windows.Forms.CheckBox()
        Me.GbParametros = New System.Windows.Forms.GroupBox()
        Me.TbSql = New SupraReports.Client.SuggestionRichTextBox()
        Me.GbParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlParametros
        '
        Me.PnlParametros.AutoSize = True
        Me.PnlParametros.Location = New System.Drawing.Point(3, 16)
        Me.PnlParametros.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlParametros.MaximumSize = New System.Drawing.Size(236, 0)
        Me.PnlParametros.Name = "PnlParametros"
        Me.PnlParametros.Size = New System.Drawing.Size(236, 0)
        Me.PnlParametros.TabIndex = 17
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(4, 6)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(51, 13)
        Me.LblNombre.TabIndex = 14
        Me.LblNombre.Text = "Consulta:"
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(61, 3)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(321, 20)
        Me.TbNombre.TabIndex = 13
        '
        'BtnEliminarConsulta
        '
        Me.BtnEliminarConsulta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnEliminarConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnEliminarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminarConsulta.ImageIndex = 0
        Me.BtnEliminarConsulta.ImageList = Me.IconosBotones
        Me.BtnEliminarConsulta.Location = New System.Drawing.Point(390, 0)
        Me.BtnEliminarConsulta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnEliminarConsulta.Name = "BtnEliminarConsulta"
        Me.BtnEliminarConsulta.Size = New System.Drawing.Size(24, 24)
        Me.BtnEliminarConsulta.TabIndex = 20
        Me.ToolTips.SetToolTip(Me.BtnEliminarConsulta, "Eliminar consulta")
        Me.BtnEliminarConsulta.UseVisualStyleBackColor = True
        '
        'IconosBotones
        '
        Me.IconosBotones.ImageStream = CType(resources.GetObject("IconosBotones.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosBotones.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosBotones.Images.SetKeyName(0, "if_button_cancel_1709.png")
        Me.IconosBotones.Images.SetKeyName(1, "if_kghostview_1325.png")
        '
        'BtnPrevisualizar
        '
        Me.BtnPrevisualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnPrevisualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnPrevisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPrevisualizar.ImageIndex = 1
        Me.BtnPrevisualizar.ImageList = Me.IconosBotones
        Me.BtnPrevisualizar.Location = New System.Drawing.Point(424, 0)
        Me.BtnPrevisualizar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnPrevisualizar.Name = "BtnPrevisualizar"
        Me.BtnPrevisualizar.Size = New System.Drawing.Size(24, 24)
        Me.BtnPrevisualizar.TabIndex = 22
        Me.ToolTips.SetToolTip(Me.BtnPrevisualizar, "Previsualizar consulta")
        Me.BtnPrevisualizar.UseVisualStyleBackColor = True
        '
        'CbHabilitada
        '
        Me.CbHabilitada.AutoSize = True
        Me.CbHabilitada.Location = New System.Drawing.Point(456, 5)
        Me.CbHabilitada.Name = "CbHabilitada"
        Me.CbHabilitada.Size = New System.Drawing.Size(73, 17)
        Me.CbHabilitada.TabIndex = 21
        Me.CbHabilitada.Text = "Habilitada"
        Me.CbHabilitada.UseVisualStyleBackColor = True
        '
        'GbParametros
        '
        Me.GbParametros.AutoSize = True
        Me.GbParametros.Controls.Add(Me.PnlParametros)
        Me.GbParametros.Location = New System.Drawing.Point(878, 29)
        Me.GbParametros.MaximumSize = New System.Drawing.Size(242, 0)
        Me.GbParametros.MinimumSize = New System.Drawing.Size(242, 224)
        Me.GbParametros.Name = "GbParametros"
        Me.GbParametros.Size = New System.Drawing.Size(242, 224)
        Me.GbParametros.TabIndex = 24
        Me.GbParametros.TabStop = False
        Me.GbParametros.Text = "Parámetros"
        '
        'TbSql
        '
        Me.TbSql.Font = New System.Drawing.Font("Courier New", 7.0!)
        Me.TbSql.Location = New System.Drawing.Point(3, 29)
        Me.TbSql.Name = "TbSql"
        Me.TbSql.Size = New System.Drawing.Size(871, 224)
        Me.TbSql.Sugerencias = CType(resources.GetObject("TbSql.Sugerencias"), System.Collections.ObjectModel.Collection(Of String))
        Me.TbSql.TabIndex = 25
        Me.TbSql.Text = ""
        '
        'EditarConsultaUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.TbSql)
        Me.Controls.Add(Me.GbParametros)
        Me.Controls.Add(Me.BtnPrevisualizar)
        Me.Controls.Add(Me.CbHabilitada)
        Me.Controls.Add(Me.BtnEliminarConsulta)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TbNombre)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(1125, 0)
        Me.MinimumSize = New System.Drawing.Size(1125, 166)
        Me.Name = "EditarConsultaUserControl"
        Me.Size = New System.Drawing.Size(1125, 256)
        Me.GbParametros.ResumeLayout(False)
        Me.GbParametros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlParametros As FlowLayoutPanel
    Friend WithEvents LblNombre As Label
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents BtnEliminarConsulta As Button
    Friend WithEvents IconosBotones As ImageList
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents CbHabilitada As CheckBox
    Friend WithEvents BtnPrevisualizar As System.Windows.Forms.Button
    Friend WithEvents GbParametros As System.Windows.Forms.GroupBox
    Friend WithEvents TbSql As SupraReports.Client.SuggestionRichTextBox
End Class
