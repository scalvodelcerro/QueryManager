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
    Me.LblResult = New System.Windows.Forms.Label()
    Me.TbSqlResult = New System.Windows.Forms.RichTextBox()
    Me.PnlParametros = New System.Windows.Forms.FlowLayoutPanel()
    Me.LblParametros = New System.Windows.Forms.Label()
    Me.TbSql = New System.Windows.Forms.RichTextBox()
    Me.LblNombre = New System.Windows.Forms.Label()
    Me.TbNombre = New System.Windows.Forms.TextBox()
    Me.BtnEliminarConsulta = New System.Windows.Forms.Button()
    Me.IconosBotones = New System.Windows.Forms.ImageList(Me.components)
    Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
    Me.SuspendLayout()
    '
    'LblResult
    '
    Me.LblResult.AutoSize = True
    Me.LblResult.Location = New System.Drawing.Point(699, 8)
    Me.LblResult.Name = "LblResult"
    Me.LblResult.Size = New System.Drawing.Size(71, 13)
    Me.LblResult.TabIndex = 19
    Me.LblResult.Text = "Sql resultado:"
    '
    'TbSqlResult
    '
    Me.TbSqlResult.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TbSqlResult.HideSelection = False
    Me.TbSqlResult.Location = New System.Drawing.Point(648, 29)
    Me.TbSqlResult.Name = "TbSqlResult"
    Me.TbSqlResult.ReadOnly = True
    Me.TbSqlResult.Size = New System.Drawing.Size(379, 134)
    Me.TbSqlResult.TabIndex = 18
    Me.TbSqlResult.Text = ""
    '
    'PnlParametros
    '
    Me.PnlParametros.AutoSize = True
    Me.PnlParametros.Location = New System.Drawing.Point(392, 48)
    Me.PnlParametros.MaximumSize = New System.Drawing.Size(250, 0)
    Me.PnlParametros.MinimumSize = New System.Drawing.Size(250, 115)
    Me.PnlParametros.Name = "PnlParametros"
    Me.PnlParametros.Size = New System.Drawing.Size(250, 115)
    Me.PnlParametros.TabIndex = 17
    '
    'LblParametros
    '
    Me.LblParametros.AutoSize = True
    Me.LblParametros.Location = New System.Drawing.Point(392, 32)
    Me.LblParametros.Name = "LblParametros"
    Me.LblParametros.Size = New System.Drawing.Size(60, 13)
    Me.LblParametros.TabIndex = 16
    Me.LblParametros.Text = "Parámetros"
    '
    'TbSql
    '
    Me.TbSql.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TbSql.Location = New System.Drawing.Point(7, 29)
    Me.TbSql.Name = "TbSql"
    Me.TbSql.Size = New System.Drawing.Size(379, 134)
    Me.TbSql.TabIndex = 15
    Me.TbSql.Text = ""
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
    Me.TbNombre.Size = New System.Drawing.Size(325, 20)
    Me.TbNombre.TabIndex = 13
    '
    'BtnEliminarConsulta
    '
    Me.BtnEliminarConsulta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEliminarConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
    Me.BtnEliminarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.BtnEliminarConsulta.ImageIndex = 0
    Me.BtnEliminarConsulta.ImageList = Me.IconosBotones
    Me.BtnEliminarConsulta.Location = New System.Drawing.Point(389, 0)
    Me.BtnEliminarConsulta.Margin = New System.Windows.Forms.Padding(0)
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
    Me.IconosBotones.Images.SetKeyName(0, "if_cancel_1712.png")
    '
    'EditarConsultaUserControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.Controls.Add(Me.BtnEliminarConsulta)
    Me.Controls.Add(Me.LblResult)
    Me.Controls.Add(Me.TbSqlResult)
    Me.Controls.Add(Me.PnlParametros)
    Me.Controls.Add(Me.LblParametros)
    Me.Controls.Add(Me.TbSql)
    Me.Controls.Add(Me.LblNombre)
    Me.Controls.Add(Me.TbNombre)
    Me.MaximumSize = New System.Drawing.Size(1030, 0)
    Me.MinimumSize = New System.Drawing.Size(1030, 166)
    Me.Name = "EditarConsultaUserControl"
    Me.Size = New System.Drawing.Size(1030, 166)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LblResult As Label
  Friend WithEvents TbSqlResult As RichTextBox
  Friend WithEvents PnlParametros As FlowLayoutPanel
  Friend WithEvents LblParametros As Label
  Friend WithEvents TbSql As RichTextBox
  Friend WithEvents LblNombre As Label
  Friend WithEvents TbNombre As TextBox
  Friend WithEvents BtnEliminarConsulta As Button
  Friend WithEvents IconosBotones As ImageList
  Friend WithEvents ToolTips As ToolTip
End Class
