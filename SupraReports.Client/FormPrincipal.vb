Imports System.IO
Imports SupraReports.Model

Public Class FormPrincipal
  Private db As SupraReportsContext
  Private usuario As Usuario
  Private informe As Informe
  Private horaComienzoLanzarInformes As Date

  Private WithEvents InformeService As InformeService
  Private proyectoService As ProyectoService
  Private usuarioService As UsuarioService

  Public Sub New()
    InitializeComponent()

    InformeService = New InformeService()
    proyectoService = New ProyectoService()
    usuarioService = New UsuarioService()
  End Sub

  Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    CargarUsuario()
    CargarComboProyectos()
    CargarComboInformes()
    DeseleccionarInforme()
    HabilitarControles()
  End Sub

  Private Sub CbProyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProyecto.SelectedIndexChanged
    CargarComboInformes()
    DeseleccionarInforme()
    HabilitarControles()
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

  Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
    If ValidarCambioInforme() Then
      Dim nuevoInformeDialog As FormNuevoInforme = New FormNuevoInforme()
      If nuevoInformeDialog.ShowDialog(Me) = DialogResult.OK Then
        informe = Informe.Crear(nuevoInformeDialog.TbNombre.Text, Environment.UserName)
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
    PnlEditar.Controls.Add(control)
    PnlEditar.ScrollControlIntoView(control)
  End Sub

  Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
    InformeService.ExportarAExcel(informe, ComponerRutaSalidaInforme(informe), usuario.MaximoNumeroFilasConsulta)
  End Sub

  Private Sub BtnProgramar_Click(sender As Object, e As EventArgs) Handles BtnProgramar.Click
    Dim formProgramaciones As FormProgramaciones = New FormProgramaciones()
    formProgramaciones.ShowDialog(Me)
  End Sub

  Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
    Dim formConfiguracion As FormConfiguracion = New FormConfiguracion()
    formConfiguracion.ShowDialog(Me)
  End Sub

  Private Sub BtnEjecutarProgramaciones_Click(sender As Object, e As EventArgs) Handles BtnEjecutarProgramaciones.Click
    MinimizarEnAreaNotificacion()
    horaComienzoLanzarInformes = DateTime.Now
    LanzarProgramacionesDe(horaComienzoLanzarInformes)
    TimerSegundo.Start()
  End Sub

  Private Sub TimerSegundo_Tick(sender As Object, e As EventArgs) Handles TimerSegundo.Tick
    Dim horaEjecucion = DateTime.Now
    If horaEjecucion.Second = 0 Then
      Console.WriteLine("Tick: {0}", horaEjecucion.ToLongTimeString)
      LanzarProgramacionesDe(horaEjecucion)
    End If
  End Sub

  Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If Not ValidarCambioInforme() Then
      e.Cancel = True
    End If
  End Sub

  Private Sub MenuIconoNotificacionCancelarProgramaciones_Click(sender As Object, e As EventArgs) Handles MenuIconoNotificacionCancelarProgramaciones.Click
    Show()
    IconoNotificacion.Visible = False
    TimerSegundo.Stop()

    Dim formEjecuciones As FormResumenEjecuciones = New FormResumenEjecuciones(horaComienzoLanzarInformes)
    formEjecuciones.ShowDialog(Me)
  End Sub

  Private Sub PnlEditar_Resize(sender As Object, e As EventArgs) Handles PnlEditar.Resize
    BtnAnadirConsulta.Location = New Point(BtnAnadirConsulta.Location.X, PnlEditar.Location.Y + PnlEditar.Size.Height + 4)
  End Sub

  Private Sub InformeService_ProgresoExportar(sender As Object, e As ProgresoEventArgs) Handles InformeService.ProgresoExportar
    PbEjecutar.Value = e.Progress
    PbEjecutar.Visible = PbEjecutar.Value > 0
  End Sub

  Private Sub CargarUsuario()
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      usuario = db.Usuarios.Include("Permisos").AsNoTracking().
        SingleOrDefault(Function(x) x.Nombre = Environment.UserName)
    End Using
  End Sub

  Private Sub CargarComboProyectos()
    Dim proyectos As IList(Of Proyecto) = proyectoService.ObtenerProyectosDeUsuario(Environment.UserName)
    proyectos.Insert(0, Proyecto.Crear("--"))
    ProyectoBindingSource.DataSource = proyectos
  End Sub

  Private Sub CargarComboInformes()
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Dim idProyecto As Integer = CbProyecto.SelectedValue
      If idProyecto <= 0 Then
        InformeBindingSource.DataSource = InformeService.ObtenerInformesPersonalesDeUsuario(Environment.UserName)
      Else
        InformeBindingSource.DataSource = InformeService.ObtenerInformesDeProyecto(idProyecto)
      End If
    End Using
  End Sub

  Private Sub CargarConsultas()
    PnlEditar.Controls.Clear()
    If informe IsNot Nothing Then
      For Each consulta In informe.Consultas
        Dim control As EditarConsultaUserControl = New EditarConsultaUserControl(db, consulta)
        PnlEditar.Controls.Add(control)
      Next
    End If
  End Sub

  Private Sub LanzarProgramacionesDe(horaEjecucion As Date)
    Dim programaciones As IList(Of Programacion) = InformeService.ObtenerProgramacionesDeUsuario(Environment.UserName)
    For Each p In programaciones.AsParallel()
      If p.ProgramadoPara(horaEjecucion) Then
        InformeService.ExportarAExcel(p.Informe, ComponerRutaSalidaInforme(p.Informe), usuario.MaximoNumeroFilasConsulta)
        IconoNotificacion.ShowBalloonTip(1000, "Ejecución informe", String.Format("Se ha finalizado la ejecución del informe {0}", p.Informe.Nombre), ToolTipIcon.Info)
      End If
    Next
  End Sub

  Private Sub CrearInforme()
    db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
    If CbProyecto.SelectedIndex > 0 Then
      informe.Proyecto = db.Proyectos.Find(CbProyecto.SelectedItem.Id)
    End If
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
    db.Programaciones.Remove(informe.Programacion)
    db.Informes.Remove(informe)
    informe = Nothing
  End Sub

  Private Shared Function ComponerRutaSalidaInforme(informe As Informe) As String
    Dim folderPath = My.Settings.RutaDirectorioSalida
    If String.IsNullOrEmpty(folderPath) Then folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim fileName As String = String.Format("{0}_{1}.xlsx", informe.Nombre.Replace(" ", "_"), DateTime.Now.ToString("yyyyMMdd_HHmmss"))
    Dim outputFile As String = Path.Combine(folderPath, fileName)
    Return outputFile
  End Function

  Private Sub HabilitarControles()
    Dim informeCargado As Boolean = informe IsNot Nothing
    Dim sinProyecto As Boolean = CbProyecto.SelectedIndex <= 0
    Dim esUsuarioAdministrador As Boolean = usuarioService.EsAdministradorProyecto(Environment.UserName, CbProyecto.SelectedValue)
    Dim permitirModificaciones = sinProyecto OrElse esUsuarioAdministrador
    BtnNuevo.Enabled = permitirModificaciones
    BtnGuardar.Enabled = informeCargado AndAlso permitirModificaciones
    BtnGuardarComo.Enabled = informeCargado AndAlso permitirModificaciones
    BtnEliminarInforme.Enabled = informeCargado AndAlso permitirModificaciones
    BtnEjecutar.Enabled = informeCargado
    BtnAnadirConsulta.Enabled = informeCargado AndAlso permitirModificaciones
    For Each controlConsulta In PnlEditar.Controls.OfType(Of EditarConsultaUserControl)
      controlConsulta.TbNombre.Enabled = permitirModificaciones
      controlConsulta.TbSql.Enabled = permitirModificaciones
      controlConsulta.BtnEliminarConsulta.Enabled = permitirModificaciones
      controlConsulta.CbHabilitada.Enabled = permitirModificaciones
    Next
  End Sub

  Private Sub MinimizarEnAreaNotificacion()
    IconoNotificacion.Visible = True
    IconoNotificacion.ShowBalloonTip(1000)
    Hide()
  End Sub

  Private Function ValidarCambioInforme() As Boolean
    If informe IsNot Nothing AndAlso HayCambiosSinGuardar() Then
      Dim resultado = MessageBox.Show("¿Desea guardar los cambios?", "Cambios en el informe", MessageBoxButtons.YesNoCancel)
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
