<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfiguracionProyecto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DgPermisosUsuario = New System.Windows.Forms.DataGridView()
        Me.GbPermisosUsuario = New System.Windows.Forms.GroupBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.NombreUsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TienePermisoColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EsAdministradorColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PermisoUsuarioDtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DgPermisosUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPermisosUsuario.SuspendLayout()
        CType(Me.PermisoUsuarioDtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgPermisosUsuario
        '
        Me.DgPermisosUsuario.AllowUserToAddRows = False
        Me.DgPermisosUsuario.AllowUserToDeleteRows = False
        Me.DgPermisosUsuario.AutoGenerateColumns = False
        Me.DgPermisosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPermisosUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreUsuarioColumn, Me.TienePermisoColumn, Me.EsAdministradorColumn})
        Me.DgPermisosUsuario.DataSource = Me.PermisoUsuarioDtoBindingSource
        Me.DgPermisosUsuario.Location = New System.Drawing.Point(6, 19)
        Me.DgPermisosUsuario.Name = "DgPermisosUsuario"
        Me.DgPermisosUsuario.RowHeadersVisible = False
        Me.DgPermisosUsuario.Size = New System.Drawing.Size(343, 366)
        Me.DgPermisosUsuario.TabIndex = 0
        '
        'GbPermisosUsuario
        '
        Me.GbPermisosUsuario.Controls.Add(Me.DgPermisosUsuario)
        Me.GbPermisosUsuario.Location = New System.Drawing.Point(17, 12)
        Me.GbPermisosUsuario.Name = "GbPermisosUsuario"
        Me.GbPermisosUsuario.Size = New System.Drawing.Size(355, 391)
        Me.GbPermisosUsuario.TabIndex = 1
        Me.GbPermisosUsuario.TabStop = False
        Me.GbPermisosUsuario.Text = "Permisos usuario"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnAceptar.Location = New System.Drawing.Point(157, 409)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'NombreUsuarioColumn
        '
        Me.NombreUsuarioColumn.DataPropertyName = "NombreUsuario"
        Me.NombreUsuarioColumn.HeaderText = "Usuario"
        Me.NombreUsuarioColumn.Name = "NombreUsuarioColumn"
        Me.NombreUsuarioColumn.ReadOnly = True
        Me.NombreUsuarioColumn.Width = 200
        '
        'TienePermisoColumn
        '
        Me.TienePermisoColumn.DataPropertyName = "TienePermiso"
        Me.TienePermisoColumn.HeaderText = "Permiso"
        Me.TienePermisoColumn.Name = "TienePermisoColumn"
        Me.TienePermisoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TienePermisoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TienePermisoColumn.Width = 70
        '
        'EsAdministradorColumn
        '
        Me.EsAdministradorColumn.DataPropertyName = "EsAdministrador"
        Me.EsAdministradorColumn.HeaderText = "Admin."
        Me.EsAdministradorColumn.Name = "EsAdministradorColumn"
        Me.EsAdministradorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EsAdministradorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EsAdministradorColumn.Width = 70
        '
        'PermisoUsuarioDtoBindingSource
        '
        Me.PermisoUsuarioDtoBindingSource.DataSource = GetType(SupraReports.Client.PermisoUsuarioDto)
        '
        'FormConfiguracionProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GbPermisosUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormConfiguracionProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración del proyecto"
        CType(Me.DgPermisosUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPermisosUsuario.ResumeLayout(False)
        CType(Me.PermisoUsuarioDtoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgPermisosUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents GbPermisosUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents PermisoUsuarioDtoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents NombreUsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TienePermisoColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EsAdministradorColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
