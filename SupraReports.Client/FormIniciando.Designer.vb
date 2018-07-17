<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIniciando
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIniciando))
        Me.PicIniciando = New System.Windows.Forms.PictureBox()
        Me.LblConexionRmis = New System.Windows.Forms.Label()
        Me.LblConexionSupra = New System.Windows.Forms.Label()
        Me.IconosConexion = New System.Windows.Forms.ImageList(Me.components)
        Me.PicIconoConexionRmis = New System.Windows.Forms.PictureBox()
        Me.PicIconoConexionSupra = New System.Windows.Forms.PictureBox()
        CType(Me.PicIniciando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicIconoConexionRmis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicIconoConexionSupra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicIniciando
        '
        Me.PicIniciando.Image = Global.SupraReports.Client.My.Resources.Resources.nessie_512
        Me.PicIniciando.Location = New System.Drawing.Point(12, 5)
        Me.PicIniciando.Name = "PicIniciando"
        Me.PicIniciando.Size = New System.Drawing.Size(379, 280)
        Me.PicIniciando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicIniciando.TabIndex = 0
        Me.PicIniciando.TabStop = False
        '
        'LblConexionRmis
        '
        Me.LblConexionRmis.AutoSize = True
        Me.LblConexionRmis.Location = New System.Drawing.Point(186, 301)
        Me.LblConexionRmis.Name = "LblConexionRmis"
        Me.LblConexionRmis.Size = New System.Drawing.Size(167, 13)
        Me.LblConexionRmis.TabIndex = 2
        Me.LblConexionRmis.Text = "Comprobando conexión a RMIS..."
        '
        'LblConexionSupra
        '
        Me.LblConexionSupra.AutoSize = True
        Me.LblConexionSupra.Location = New System.Drawing.Point(185, 339)
        Me.LblConexionSupra.Name = "LblConexionSupra"
        Me.LblConexionSupra.Size = New System.Drawing.Size(168, 13)
        Me.LblConexionSupra.TabIndex = 3
        Me.LblConexionSupra.Text = "Comprobando conexión a Supra..."
        '
        'IconosConexion
        '
        Me.IconosConexion.ImageStream = CType(resources.GetObject("IconosConexion.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosConexion.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosConexion.Images.SetKeyName(0, "icono_ok")
        Me.IconosConexion.Images.SetKeyName(1, "icono_fail")
        Me.IconosConexion.Images.SetKeyName(2, "icono_loading")
        '
        'PicIconoConexionRmis
        '
        Me.PicIconoConexionRmis.Image = Global.SupraReports.Client.My.Resources.Resources.spinner_loading
        Me.PicIconoConexionRmis.Location = New System.Drawing.Point(359, 291)
        Me.PicIconoConexionRmis.Name = "PicIconoConexionRmis"
        Me.PicIconoConexionRmis.Size = New System.Drawing.Size(32, 32)
        Me.PicIconoConexionRmis.TabIndex = 4
        Me.PicIconoConexionRmis.TabStop = False
        '
        'PicIconoConexionSupra
        '
        Me.PicIconoConexionSupra.Image = Global.SupraReports.Client.My.Resources.Resources.spinner_loading
        Me.PicIconoConexionSupra.Location = New System.Drawing.Point(359, 329)
        Me.PicIconoConexionSupra.Name = "PicIconoConexionSupra"
        Me.PicIconoConexionSupra.Size = New System.Drawing.Size(32, 32)
        Me.PicIconoConexionSupra.TabIndex = 5
        Me.PicIconoConexionSupra.TabStop = False
        '
        'FormIniciando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicIconoConexionSupra)
        Me.Controls.Add(Me.PicIconoConexionRmis)
        Me.Controls.Add(Me.LblConexionSupra)
        Me.Controls.Add(Me.LblConexionRmis)
        Me.Controls.Add(Me.PicIniciando)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormIniciando"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PicIniciando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicIconoConexionRmis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicIconoConexionSupra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicIniciando As System.Windows.Forms.PictureBox
    Friend WithEvents LblConexionRmis As System.Windows.Forms.Label
    Friend WithEvents LblConexionSupra As System.Windows.Forms.Label
    Friend WithEvents IconosConexion As System.Windows.Forms.ImageList
    Friend WithEvents PicIconoConexionRmis As System.Windows.Forms.PictureBox
    Friend WithEvents PicIconoConexionSupra As System.Windows.Forms.PictureBox
End Class
