Imports System.IO
Imports SupraReports.Model
Imports RMIS_Lib

Public Class FormPrincipal
  Private db As SupraReportsContext
  'Private base As Base
  Private usuario As Usuario
  Private informe As Informe
  Private horaComienzoLanzarInformes As Date

  Private WithEvents InformeService As InformeService
  Private proyectoService As ProyectoService
  Private usuarioService As UsuarioService
  Private loggingService As ILoggingService

  Public Sub New()
    InitializeComponent()

    'base = New Base(My.Resources.Login_OracleDb,
    '               My.Resources.Login_OracleUser,
    '               My.Resources.Login_OraclePassword,
    '               My.Resources.Login_App)
    'loggingService = New BaseLoggingService(base)
    InformeService = New InformeService(loggingService)
    proyectoService = New ProyectoService()
    usuarioService = New UsuarioService()
  End Sub

  Private Sub FormPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    Me.Visible = False
  End Sub

  Private Async Sub FormPrincipal_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
    Login()
    Me.Visible = False
    Await Task.WhenAll({
        Task.Run(Sub() MostrarVentanaIniciando()),
        Task.Run(Sub() CargarUsuario())
    })
    Me.Visible = True
    Me.WindowState = FormWindowState.Normal
    'GbConsultas.AutoSize = True
    CargarComboProyectos()
    CargarComboInformes()
    DeseleccionarInforme()
    HabilitarControles()
    If CbProyecto.Items.Count > 0 Then
      CbProyecto.SelectedIndex = -1
      CbProyecto.SelectedIndex = 0
    End If
    IniciarProgramaciones()
  End Sub

  Private Sub CbProyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProyecto.SelectedIndexChanged
    ValidarCambioInforme()
    CargarComboInformes()
    DeseleccionarInforme()
    HabilitarControles()
    If CbInforme.Items.Count > 0 Then
      CbInforme.SelectedIndex = 0
    End If
  End Sub

  Private Sub CbInforme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbInforme.SelectedIndexChanged
    If Not CbInforme.Focused OrElse ValidarCambioInforme() Then
      PnlEditar.Controls.Clear()
      If CbInforme.SelectedItem IsNot Nothing Then
        SeleccionarInforme()
        CargarConsultas()
      End If
      HabilitarControles()
    End If
  End Sub

  Private Sub BtnNuevoProyecto_Click(sender As Object, e As EventArgs) Handles BtnNuevoProyecto.Click
    Dim formNuevoProyecto = New FormNuevoProyecto()
    If formNuevoProyecto.ShowDialog(Me) = DialogResult.OK Then
      Dim nuevoProyecto = proyectoService.CrearProyecto(formNuevoProyecto.TbNombre.Text, ObtenerNombreUsuario())
      CargarComboProyectos()
      CbProyecto.SelectedValue = nuevoProyecto.Id
      CargarComboInformes()
      DeseleccionarInforme()
      HabilitarControles()
    End If
  End Sub

  Private Sub BtnConfigurarProyecto_Click(sender As Object, e As EventArgs) Handles BtnConfigurarProyecto.Click
    Dim formConfiguracionProyecto As FormConfiguracionProyecto = New FormConfiguracionProyecto(CbProyecto.SelectedItem)
    formConfiguracionProyecto.ShowDialog(Me)
    CargarComboProyectos()
    CargarComboInformes()
    DeseleccionarInforme()
    HabilitarControles()
  End Sub

  Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevoInforme.Click
    If ValidarCambioInforme() Then
      Dim nuevoInformeDialog As FormNuevoInforme = New FormNuevoInforme()
      If nuevoInformeDialog.ShowDialog(Me) = DialogResult.OK Then
        informe = Informe.Crear(nuevoInformeDialog.TbNombre.Text, ObtenerNombreUsuario())
        informe.AnadirConsulta(Consulta.Crear(String.Empty, String.Empty))

        CrearInforme()

        CargarComboInformes()
        CbInforme.SelectedItem = CbInforme.Items.Cast(Of Informe).SingleOrDefault(Function(x) x.Id = informe.Id)
        CargarConsultas()
        HabilitarControles()
      End If
    End If
  End Sub

  Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    db.SaveChanges()
  End Sub

  Private Sub BtnGuardarComo_Click(sender As Object, e As EventArgs) Handles BtnGuardarComo.Click
    Dim nuevoInformeDialog As FormNuevoInforme = New FormNuevoInforme()
    If nuevoInformeDialog.ShowDialog(Me) = DialogResult.OK Then
      DescartarCambios()

      informe = Informe.Copiar(informe)
      informe.Nombre = nuevoInformeDialog.TbNombre.Text

      CrearInforme()

      CargarComboInformes()
      CbInforme.SelectedItem = CbInforme.Items.Cast(Of Informe).SingleOrDefault(Function(x) x.Id = informe.Id)
      CargarConsultas()
      HabilitarControles()
    End If
  End Sub

  Private Sub BtnEliminarInforme_Click(sender As Object, e As EventArgs) Handles BtnEliminarInforme.Click
    If MessageBox.Show(Me, "¿Desea eliminar el informe?", "Confirmar eliminación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
      EliminarInforme()
      GuardarCambios()

      CargarComboInformes()
      DeseleccionarInforme()
      CargarConsultas()
      HabilitarControles()
    End If
  End Sub

  Private Sub BtnAnadirConsulta_Click(sender As Object, e As EventArgs) Handles BtnAnadirConsulta.Click
    Dim consulta As Consulta = Consulta.Crear(String.Empty, String.Empty)
    informe.AnadirConsulta(consulta)

    Dim control As EditarConsultaUserControl = New EditarConsultaUserControl(db, consulta)
    control.Width = PnlEditar.Width - 20
    PnlEditar.Controls.Add(control)
    PnlEditar.ScrollControlIntoView(control)
  End Sub

  Private Sub RutaPorDefectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutaPorDefectoToolStripMenuItem.Click
    Dim formConfiguracion As FormConfiguracion = New FormConfiguracion(usuario)
    formConfiguracion.ShowDialog(Me)
  End Sub

  Private Sub ProgramarInformesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramarInformesToolStripMenuItem.Click
    Dim formProgramaciones As FormProgramaciones = New FormProgramaciones(ObtenerNombreUsuario())
    formProgramaciones.ShowDialog(Me)
  End Sub

  Private Sub VerProgramacionesHistóricasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerProgramacionesHistóricasToolStripMenuItem.Click
    Dim formEjecuciones As FormResumenEjecuciones = New FormResumenEjecuciones(ObtenerNombreUsuario())
    formEjecuciones.ShowDialog(Me)
  End Sub

  Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
    Dim formAcercaDe = New FormAcercaDe()
    formAcercaDe.ShowDialog(Me)
  End Sub

  Private Async Sub BtnEjecutar_ClickAsync(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
    Dim rutaSalidaInforme As String = ComponerRutaSalidaInforme(informe)
    Await Task.Run(Sub() InformeService.ExportarAExcel(informe, rutaSalidaInforme, ObtenerNombreUsuario(), usuario.MaximoNumeroFilasConsulta, False))
    Process.Start(rutaSalidaInforme)
  End Sub

  Private Sub BtnConfigurarInforme_Click(sender As Object, e As EventArgs) Handles BtnConfigurarInforme.Click
    Dim formConfigurarInforme = New FormConfiguracionInforme(informe, ObtenerNombreUsuario())
    formConfigurarInforme.ShowDialog(Me)
  End Sub

  Private Async Sub TimerSegundo_TickAsync(sender As Object, e As EventArgs) Handles TimerSegundo.Tick
    Dim horaEjecucion = DateTime.Now
    If horaEjecucion.Second = 0 Then
      Await Task.Run(Sub() LanzarProgramacionesDe(horaEjecucion))
    End If
  End Sub

  Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If Not ValidarCambioInforme() Then
      e.Cancel = True
    End If
    'base.RegistrarLog(My.Resources.Login_App, "Cerrando sesion.", "", False)
    'base.Logout()
  End Sub

  Private Sub FormPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    If (WindowState = FormWindowState.Minimized) Then
      MinimizarEnAreaNotificacion()
    End If
  End Sub

  Private Sub PnlEditar_Resize(sender As Object, e As EventArgs) Handles PnlEditar.Resize
    For Each control In PnlEditar.Controls.OfType(Of EditarConsultaUserControl)
      control.Width = PnlEditar.Width - 20
    Next
  End Sub

  Private Sub IconoNotificacion_Click(sender As Object, e As EventArgs) Handles IconoNotificacion.Click
    Show()
    WindowState = FormWindowState.Normal
  End Sub

  Private Sub InformeService_ProgresoExportar(sender As Object, e As ProgresoEventArgs) Handles InformeService.ProgresoExportar
    ActualizarProgresoEjecucion(e.Progress)
  End Sub

  Delegate Sub ActualizarProgresoEjecucionCallback(progreso As Integer)
  Private Sub ActualizarProgresoEjecucion(progreso As Integer)
    If InvokeRequired Then
      Invoke(New ActualizarProgresoEjecucionCallback(AddressOf ActualizarProgresoEjecucion), {progreso})
    Else
      If progreso > 0 AndAlso progreso < 100 Then
        ImgNessie.Image = My.Resources.nessie_animado
      Else
        ImgNessie.Image = My.Resources.nessie_512
      End If
      PbEjecutar.Value = progreso
      PbEjecutar.Visible = PbEjecutar.Value > 0
    End If
  End Sub

  Delegate Sub MostrarVentanaIniciandoCallback()
  Private Sub MostrarVentanaIniciando()
    If InvokeRequired Then
      Invoke(New MostrarVentanaIniciandoCallback(AddressOf MostrarVentanaIniciando))
    Else
      Dim formIniciando = New FormIniciando()
      formIniciando.ShowDialog(Me)
    End If
  End Sub

  Private Sub Login()
    'If base.Login() Then
    '  base.RegistrarLog(My.Resources.Login_App, "Abriendo sesión.", "", False)
    'Else
    '  SalirPorUsuarioNoAutorizado()
    'End If
  End Sub

  Private Sub SalirPorUsuarioNoAutorizado()
    MessageBox.Show("No tiene permisos para acceder a la aplicación", "Usuario no autorizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End
  End Sub

  Private Function ObtenerNombreUsuario() As String
    'If base Is Nothing Then Return String.Empty
    'Return base.CDUSUARIO
    Return Environment.UserName
  End Function

  Private Sub CargarUsuario()
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Dim nombreUsuario = ObtenerNombreUsuario()
      usuario = db.Usuarios.AsNoTracking().
        SingleOrDefault(Function(x) x.Nombre = nombreUsuario)
    End Using
    If usuario Is Nothing Then SalirPorUsuarioNoAutorizado()
  End Sub


  Private Sub CargarComboProyectos()
    Try
      ProyectoBindingSource.DataSource = proyectoService.ObtenerProyectosDeUsuario(ObtenerNombreUsuario())
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub CargarComboInformes()
    InformeBindingSource.Clear()
    InformeBindingSource.DataSource = InformeService.ObtenerInformesDeProyecto(CbProyecto.SelectedValue)
  End Sub

  Private Sub CargarConsultas()
    PnlEditar.Controls.Clear()
    'PnlEditar.Size = PnlEditar.MinimumSize
    'GbConsultas.Size = GbConsultas.MinimumSize
    If informe IsNot Nothing Then
      For Each consulta In informe.Consultas
        Dim control As EditarConsultaUserControl = New EditarConsultaUserControl(db, consulta)
        control.Width = PnlEditar.Width - 20
        PnlEditar.Controls.Add(control)
      Next
    End If
  End Sub

  Private Sub IniciarProgramaciones()
    horaComienzoLanzarInformes = DateTime.Now
    LanzarProgramacionesDe(horaComienzoLanzarInformes)
    TimerSegundo.Start()
  End Sub

  Private Sub LanzarProgramacionesDe(horaEjecucion As Date)
    Dim nombreUsuarioEjecucion = ObtenerNombreUsuario()
    Dim programaciones As IList(Of Programacion) = InformeService.ObtenerProgramacionesDeUsuario(nombreUsuarioEjecucion)

    For Each p In programaciones.AsParallel()
      If p.ProgramadoPara(horaEjecucion) Then
        InformeService.ExportarAExcel(p.Informe, ComponerRutaSalidaInforme(p.Informe), nombreUsuarioEjecucion, usuario.MaximoNumeroFilasConsulta, True)
        IconoNotificacion.ShowBalloonTip(1000, "Ejecución informe", String.Format("Se ha finalizado la ejecución del informe {0}", p.Informe.Nombre), ToolTipIcon.Info)
      End If
    Next
  End Sub

  Private Sub CrearInforme()
    db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
    informe.Proyecto = db.Proyectos.Find(CbProyecto.SelectedValue)
    db.Informes.Add(informe)
    db.SaveChanges()
  End Sub

  Private Sub SeleccionarInforme()
    db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
    Dim idInforme As Integer = CbInforme.SelectedItem.Id
    informe = db.Informes.SingleOrDefault(Function(x) x.Id = idInforme)
  End Sub

  Private Sub DeseleccionarInforme()
    CbInforme.SelectedIndex = -1
    informe = Nothing
  End Sub

  Private Sub EliminarInforme()
    'db.Programaciones.Remove(informe.Programacion)
    db.Informes.Remove(informe)
    informe = Nothing
  End Sub

  Private Function ComponerRutaSalidaInforme(informe As Informe) As String
    Dim folderPath As String
    Dim confInforme As ConfiguracionInforme = InformeService.ObtenerConfiguracionInforme(informe.Id, ObtenerNombreUsuario())
    If confInforme Is Nothing Then
      folderPath = usuarioService.ObtenerRutaFicheroDefecto(ObtenerNombreUsuario())
      If String.IsNullOrEmpty(folderPath) Then folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Else
      folderPath = confInforme.RutaFichero
    End If

    Dim fileName As String = String.Format("{0}_{1}.xlsx", informe.Nombre.Replace(" ", "_"), DateTime.Now.ToString("yyyyMMdd_HHmmss"))
    Return Path.Combine(folderPath, fileName)
  End Function

  Private Sub HabilitarControles()
    Dim informeCargado As Boolean = informe IsNot Nothing
    Dim esUsuarioAdministrador As Boolean = usuarioService.EsAdministradorProyecto(ObtenerNombreUsuario(), CbProyecto.SelectedValue)
    Dim permitirModificaciones = esUsuarioAdministrador
    BtnConfigurarProyecto.Enabled = esUsuarioAdministrador
    BtnNuevoInforme.Enabled = permitirModificaciones
    BtnGuardar.Enabled = informeCargado AndAlso permitirModificaciones
    BtnGuardarComo.Enabled = informeCargado AndAlso permitirModificaciones
    BtnEliminarInforme.Enabled = informeCargado AndAlso permitirModificaciones
    BtnConfigurarInforme.Enabled = informeCargado
    BtnEjecutar.Enabled = informeCargado
    BtnAnadirConsulta.Enabled = informeCargado AndAlso permitirModificaciones
    For Each controlConsulta In PnlEditar.Controls.OfType(Of EditarConsultaUserControl)()
      controlConsulta.TbNombre.Enabled = permitirModificaciones
      controlConsulta.TbSql.Enabled = permitirModificaciones
      controlConsulta.BtnEliminarConsulta.Enabled = permitirModificaciones
      controlConsulta.CbHabilitada.Enabled = permitirModificaciones
    Next
    'GbConsultas.Size = GbConsultas.MinimumSize
    'PnlEditar.Size = PnlEditar.MinimumSize
  End Sub

  Private Sub MinimizarEnAreaNotificacion()
    IconoNotificacion.ShowBalloonTip(1000)
    Hide()
  End Sub

  Private Function ValidarCambioInforme() As Boolean
    If informe IsNot Nothing AndAlso HayCambiosSinGuardar() Then
      Dim resultado = MessageBox.Show("¿Desea guardar los cambios?", "Cambios en el informe", MessageBoxButtons.YesNo)
      Select Case resultado
        Case DialogResult.Yes
          GuardarCambios()
          DeseleccionarInforme()
          Return True
        Case DialogResult.No
          DescartarCambios()
          DeseleccionarInforme()
          Return True
        Case DialogResult.Cancel
          Return False
      End Select
    End If
    Return True
  End Function

  Private Sub GuardarCambios()
    db.SaveChanges()
    If db IsNot Nothing Then db.Dispose()
  End Sub

  Private Sub DescartarCambios()
    If db IsNot Nothing Then db.Dispose()
  End Sub

  Private Function HayCambiosSinGuardar() As Boolean
    Return db IsNot Nothing AndAlso db.ChangeTracker.HasChanges
  End Function

End Class
