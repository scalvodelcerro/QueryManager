Imports System.Data.Entity
Imports SupraReports.Model

Public Class FormPrincipal
  Private db As SupraReportsContext
  Private informe As Informe

  Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    CargarInformes()
  End Sub

  Private Sub CbInforme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbInforme.SelectedIndexChanged
    If Not CbInforme.Focused OrElse ValidarCambioInforme() Then
      PnlEditar.Controls.Clear()
      If CbInforme.SelectedItem IsNot Nothing Then
        If db IsNot Nothing Then db.Dispose()
        db = New SupraReportsContext()
        informe = db.Informes.Find(CbInforme.SelectedItem.Id)
        CargarConsultas()
      End If
      EstablecerEstadoBotones()
    End If
  End Sub

  Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
    If ValidarCambioInforme() Then
      Dim nuevoInformeDialog As FormNuevoInforme = New FormNuevoInforme()
      If nuevoInformeDialog.ShowDialog(Me) = DialogResult.OK Then
        informe = Informe.Crear(nuevoInformeDialog.TbNombre.Text, Environment.UserName)
        informe.AnadirConsulta(Consulta.Crear(String.Empty, String.Empty))

        If db IsNot Nothing Then db.Dispose()
        db = New SupraReportsContext()
        db.Informes.Add(informe)
        db.SaveChanges()

        InformeBindingSource.DataSource = db.Informes.Local.ToBindingList()
        db.Informes.Load()

        CbInforme.SelectedItem = informe
        CargarConsultas()
        EstablecerEstadoBotones()
      End If
    End If
  End Sub

  Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    db.SaveChanges()
  End Sub

  Private Sub BtnGuardarComo_Click(sender As Object, e As EventArgs) Handles BtnGuardarComo.Click
    If ValidarCambioInforme() Then
      Dim nuevoInformeDialog As FormNuevoInforme = New FormNuevoInforme()

      If nuevoInformeDialog.ShowDialog(Me) = DialogResult.OK Then
        Dim nuevoInforme = Informe.Copiar(informe)
        nuevoInforme.Nombre = nuevoInformeDialog.TbNombre.Text

        If db IsNot Nothing Then db.Dispose()
        db = New SupraReportsContext()
        db.Informes.Add(nuevoInforme)
        db.SaveChanges()

        CbInforme.Items.Add(nuevoInforme)
        CbInforme.SelectedItem = nuevoInforme
        informe = nuevoInforme
        CargarConsultas()
      End If
    End If
  End Sub

  Private Sub BtnEliminarInforme_Click(sender As Object, e As EventArgs) Handles BtnEliminarInforme.Click
    db.Programaciones.Remove(informe.Programacion)
    db.Informes.Remove(informe)
    db.SaveChanges()

    informe = Nothing
    CargarInformes()
    CargarConsultas()
    EstablecerEstadoBotones()
  End Sub

  Private Sub BtnAnadirConsulta_Click(sender As Object, e As EventArgs) Handles BtnAnadirConsulta.Click
    Dim consulta As Consulta = Consulta.Crear(String.Empty, String.Empty)
    informe.AnadirConsulta(consulta)

    Dim control As EditarConsultaUserControl = New EditarConsultaUserControl(db, consulta)
    PnlEditar.Controls.Add(control)
    PnlEditar.ScrollControlIntoView(control)
  End Sub

  Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
    EjecutarInforme(informe)
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
    If db IsNot Nothing Then db.Dispose()
    TimerMinuto.Start()
  End Sub

  Private Sub TimerMinuto_Tick(sender As Object, e As EventArgs) Handles TimerMinuto.Tick
    Console.WriteLine("Tick: {0}", DateTime.Now.ToLongTimeString)
    Using db = New SupraReportsContext()
      For Each p In db.Programaciones.Include("Informe.Consultas.Parametros").AsNoTracking()
        If p.ObtenerDiasProgramados().Contains(Now.DayOfWeek) AndAlso
          p.ObtenerHoraProgramada() = Now.Hour AndAlso
          p.ObtenerMinutoProgramado() = Now.Minute Then
          EjecutarInforme(p.Informe)
        End If
      Next
    End Using
    Console.WriteLine("Tock: {0}", DateTime.Now.ToLongTimeString)
  End Sub

  Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If Not ValidarCambioInforme() Then
      e.Cancel = True
    End If
  End Sub

  Private Sub MenuIconoNotificacionCancelarProgramaciones_Click(sender As Object, e As EventArgs) Handles MenuIconoNotificacionCancelarProgramaciones.Click
    Show()
    IconoNotificacion.Visible = False
    TimerMinuto.Stop()

    If informe IsNot Nothing Then
      db = New SupraReportsContext()
      db.Informes.Attach(informe)
    End If
  End Sub

  Private Sub PnlEditar_Resize(sender As Object, e As EventArgs) Handles PnlEditar.Resize
    BtnAnadirConsulta.Location = New Point(BtnAnadirConsulta.Location.X, PnlEditar.Location.Y + PnlEditar.Size.Height + 4)
  End Sub

  Private Sub CargarInformes()
    Using db = New SupraReportsContext()
      InformeBindingSource.DataSource = db.Informes.Local.ToBindingList()
      db.Informes.Load()
    End Using

    CbInforme.SelectedItem = Nothing
    CbInforme.Text = String.Empty
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

  Private Sub EjecutarInforme(informe As Informe)
    Using excelBuilder = New ExcelBuilder(informe.Nombre, My.Settings.RutaDirectorioSalida)
      For Each consulta In informe.Consultas
        Using dao = New GeneralDao(GeneralDao.CrearConexionMySql())
          excelBuilder.AddWorksheet(consulta.Nombre, dao.EjecutarSelect(consulta.ComponerSqlResultado()))
        End Using
      Next
      excelBuilder.Build()
    End Using
  End Sub

  Private Sub EstablecerEstadoBotones()
    Dim habilitado As Boolean = informe IsNot Nothing
    BtnGuardar.Enabled = habilitado
    BtnGuardarComo.Enabled = habilitado
    BtnEliminarInforme.Enabled = habilitado
    BtnEjecutar.Enabled = habilitado
    BtnAnadirConsulta.Enabled = habilitado
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
          db.SaveChanges()
          Return True
        Case DialogResult.No
          Return True
        Case DialogResult.Cancel
          Return False
      End Select
    End If
    Return True
  End Function

  Private Function HayCambiosSinGuardar() As Boolean
    Return db.ChangeTracker.HasChanges
  End Function
End Class
