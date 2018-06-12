<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsarConsultaUserControl
  Inherits System.Windows.Forms.UserControl

  'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Me.LblNombre = New System.Windows.Forms.Label()
    Me.TbNombre = New System.Windows.Forms.TextBox()
    Me.TbSql = New System.Windows.Forms.RichTextBox()
    Me.LblParametros = New System.Windows.Forms.Label()
    Me.PnlParametros = New System.Windows.Forms.FlowLayoutPanel()
    Me.TbSqlResult = New System.Windows.Forms.RichTextBox()
    Me.LblResult = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'LblNombre
    '
    Me.LblNombre.AutoSize = True
    Me.LblNombre.Location = New System.Drawing.Point(5, 6)
    Me.LblNombre.Name = "LblNombre"
    Me.LblNombre.Size = New System.Drawing.Size(51, 13)
    Me.LblNombre.TabIndex = 5
    Me.LblNombre.Text = "Consulta:"
    '
    'TbNombre
    '
    Me.TbNombre.BackColor = System.Drawing.SystemColors.Window
    Me.TbNombre.Location = New System.Drawing.Point(65, 3)
    Me.TbNombre.Name = "TbNombre"
    Me.TbNombre.ReadOnly = True
    Me.TbNombre.Size = New System.Drawing.Size(376, 20)
    Me.TbNombre.TabIndex = 4
    '
    'TbSql
    '
    Me.TbSql.BackColor = System.Drawing.SystemColors.Window
    Me.TbSql.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TbSql.Location = New System.Drawing.Point(62, 29)
    Me.TbSql.Name = "TbSql"
    Me.TbSql.ReadOnly = True
    Me.TbSql.Size = New System.Drawing.Size(379, 134)
    Me.TbSql.TabIndex = 8
    Me.TbSql.Text = ""
    '
    'LblParametros
    '
    Me.LblParametros.AutoSize = True
    Me.LblParametros.Location = New System.Drawing.Point(444, 6)
    Me.LblParametros.Name = "LblParametros"
    Me.LblParametros.Size = New System.Drawing.Size(60, 13)
    Me.LblParametros.TabIndex = 9
    Me.LblParametros.Text = "Parámetros"
    '
    'PnlParametros
    '
    Me.PnlParametros.AutoSize = True
    Me.PnlParametros.Location = New System.Drawing.Point(447, 29)
    Me.PnlParametros.MaximumSize = New System.Drawing.Size(250, 0)
    Me.PnlParametros.MinimumSize = New System.Drawing.Size(250, 134)
    Me.PnlParametros.Name = "PnlParametros"
    Me.PnlParametros.Size = New System.Drawing.Size(250, 134)
    Me.PnlParametros.TabIndex = 10
    '
    'TbSqlResult
    '
    Me.TbSqlResult.BackColor = System.Drawing.SystemColors.Window
    Me.TbSqlResult.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TbSqlResult.Location = New System.Drawing.Point(703, 29)
    Me.TbSqlResult.Name = "TbSqlResult"
    Me.TbSqlResult.ReadOnly = True
    Me.TbSqlResult.Size = New System.Drawing.Size(379, 134)
    Me.TbSqlResult.TabIndex = 11
    Me.TbSqlResult.Text = ""
    '
    'LblResult
    '
    Me.LblResult.AutoSize = True
    Me.LblResult.Location = New System.Drawing.Point(700, 6)
    Me.LblResult.Name = "LblResult"
    Me.LblResult.Size = New System.Drawing.Size(71, 13)
    Me.LblResult.TabIndex = 12
    Me.LblResult.Text = "Sql resultado:"
    '
    'UsarConsultaUserControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.Controls.Add(Me.LblResult)
    Me.Controls.Add(Me.TbSqlResult)
    Me.Controls.Add(Me.PnlParametros)
    Me.Controls.Add(Me.LblParametros)
    Me.Controls.Add(Me.TbSql)
    Me.Controls.Add(Me.LblNombre)
    Me.Controls.Add(Me.TbNombre)
    Me.MaximumSize = New System.Drawing.Size(1106, 0)
    Me.MinimumSize = New System.Drawing.Size(1106, 166)
    Me.Name = "UsarConsultaUserControl"
    Me.Size = New System.Drawing.Size(1106, 166)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LblNombre As Label
  Friend WithEvents TbNombre As TextBox
  Friend WithEvents TbSql As RichTextBox
  Friend WithEvents LblParametros As Label
  Friend WithEvents PnlParametros As FlowLayoutPanel
  Friend WithEvents TbSqlResult As RichTextBox
  Friend WithEvents LblResult As Label
End Class
