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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarConsultaUserControl))
    Me.TbNombre = New System.Windows.Forms.TextBox()
    Me.LblNombre = New System.Windows.Forms.Label()
    Me.TbSql = New System.Windows.Forms.TextBox()
    Me.LblSql = New System.Windows.Forms.Label()
    Me.BtnCancelar = New System.Windows.Forms.Button()
    Me.LbParametros = New System.Windows.Forms.ListBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'TbNombre
    '
    Me.TbNombre.Location = New System.Drawing.Point(100, 3)
    Me.TbNombre.Name = "TbNombre"
    Me.TbNombre.Size = New System.Drawing.Size(430, 20)
    Me.TbNombre.TabIndex = 0
    '
    'LblNombre
    '
    Me.LblNombre.AutoSize = True
    Me.LblNombre.Location = New System.Drawing.Point(4, 6)
    Me.LblNombre.Name = "LblNombre"
    Me.LblNombre.Size = New System.Drawing.Size(90, 13)
    Me.LblNombre.TabIndex = 1
    Me.LblNombre.Text = "Nombre consulta:"
    '
    'TbSql
    '
    Me.TbSql.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TbSql.Location = New System.Drawing.Point(100, 29)
    Me.TbSql.Multiline = True
    Me.TbSql.Name = "TbSql"
    Me.TbSql.Size = New System.Drawing.Size(430, 134)
    Me.TbSql.TabIndex = 2
    '
    'LblSql
    '
    Me.LblSql.AutoSize = True
    Me.LblSql.Location = New System.Drawing.Point(26, 32)
    Me.LblSql.Name = "LblSql"
    Me.LblSql.Size = New System.Drawing.Size(68, 13)
    Me.LblSql.TabIndex = 3
    Me.LblSql.Text = "Sql consulta:"
    '
    'BtnCancelar
    '
    Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
    Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.BtnCancelar.Location = New System.Drawing.Point(733, 1)
    Me.BtnCancelar.Name = "BtnCancelar"
    Me.BtnCancelar.Size = New System.Drawing.Size(23, 23)
    Me.BtnCancelar.TabIndex = 4
    Me.BtnCancelar.UseVisualStyleBackColor = True
    '
    'LbParametros
    '
    Me.LbParametros.FormattingEnabled = True
    Me.LbParametros.Location = New System.Drawing.Point(605, 29)
    Me.LbParametros.Name = "LbParametros"
    Me.LbParametros.Size = New System.Drawing.Size(151, 134)
    Me.LbParametros.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(536, 32)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(63, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Parámetros:"
    '
    'EditarConsultaUserControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.LbParametros)
    Me.Controls.Add(Me.BtnCancelar)
    Me.Controls.Add(Me.LblSql)
    Me.Controls.Add(Me.TbSql)
    Me.Controls.Add(Me.LblNombre)
    Me.Controls.Add(Me.TbNombre)
    Me.Name = "EditarConsultaUserControl"
    Me.Size = New System.Drawing.Size(759, 166)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents TbNombre As TextBox
  Friend WithEvents LblNombre As Label
  Friend WithEvents TbSql As TextBox
  Friend WithEvents LblSql As Label
  Friend WithEvents BtnCancelar As Button
  Friend WithEvents LbParametros As ListBox
  Friend WithEvents Label1 As Label
End Class
