Imports SupraReports.Model

Public Class FormPrincipal
  Private db As SupraReportsContext = New SupraReportsContext()
  Private informe As Informe
  Private Const PatternParametro = "#(\w+)#"
  Private hayCambiosPendientes As Boolean = False

  Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    CargarInformes()
  End Sub

  Private Sub CbInforme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbInforme.SelectedIndexChanged
    If Not CbInforme.Focused OrElse ValidarCambioInforme() Then
      PnlEditar.Controls.Clear()
      If CbInforme.SelectedItem IsNot Nothing Then
        informe = CType(CbInforme.SelectedItem, Informe)
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

        db.Informes.Add(informe)
        db.SaveChanges()

        CbInforme.Items.Add(informe)
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

        db.Informes.Add(nuevoInforme)

        CbInforme.Items.Add(nuevoInforme)
        CbInforme.SelectedItem = nuevoInforme
        informe = nuevoInforme
        CargarConsultas()
      End If
    End If
  End Sub

  Private Sub BtnEliminarInforme_Click(sender As Object, e As EventArgs) Handles BtnEliminarInforme.Click
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

    db.Consultas.Add(consulta)

    Dim control As EditarConsultaUserControl = New EditarConsultaUserControl(db, consulta)
    PnlEditar.Controls.Add(control)
    PnlEditar.ScrollControlIntoView(control)
  End Sub

  Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
    EjecutarInforme(informe)
  End Sub

  Private Sub BtnProgramar_Click(sender As Object, e As EventArgs) Handles BtnProgramar.Click
    Dim programacionInformeDialog As FormProgramacionInforme = New FormProgramacionInforme(informe.Programacion)
    If programacionInformeDialog.ShowDialog(Me) = DialogResult.OK Then
      Dim builder As Programacion.ProgramacionBuilder = New Programacion.ProgramacionBuilder()
      builder.
        ParaInforme(informe).
        ParaHora(programacionInformeDialog.PickerHora.Value.ToString("HH:mm"))
      If programacionInformeDialog.CbLunes.Checked Then builder.ParaDia(DayOfWeek.Monday)
      If programacionInformeDialog.CbMartes.Checked Then builder.ParaDia(DayOfWeek.Tuesday)
      If programacionInformeDialog.CbMiercoles.Checked Then builder.ParaDia(DayOfWeek.Wednesday)
      If programacionInformeDialog.CbJueves.Checked Then builder.ParaDia(DayOfWeek.Thursday)
      If programacionInformeDialog.CbViernes.Checked Then builder.ParaDia(DayOfWeek.Friday)
      If programacionInformeDialog.CbSabado.Checked Then builder.ParaDia(DayOfWeek.Saturday)
      If programacionInformeDialog.CbDomingo.Checked Then builder.ParaDia(DayOfWeek.Sunday)

      Dim p = builder.Build()
      If p.HayAlgunDiaProgramado() Then
        If informe.EstaProgramado() Then
          db.Programaciones.Remove(informe.Programacion)
        End If
        db.Programaciones.Add(p)
        db.SaveChanges()
      End If
    End If
  End Sub

  Private Sub BtnEjecutarProgramaciones_Click(sender As Object, e As EventArgs) Handles BtnEjecutarProgramaciones.Click
    MinimizarEnAreaNotificacion()
    TimerMinuto.Start()
  End Sub

  Private Sub TimerMinuto_Tick(sender As Object, e As EventArgs) Handles TimerMinuto.Tick
    Dim programaciones As IEnumerable(Of Programacion) = db.Programaciones.AsNoTracking().AsEnumerable()

    For Each p In programaciones
      If p.ObtenerDiasProgramados().Contains(Now.DayOfWeek) AndAlso
        p.ObtenerHoraProgramada() = Now.Hour AndAlso
        p.ObtenerMinutoProgramado() = Now.Minute Then
        EjecutarInforme(p.Informe)
      End If
    Next
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
  End Sub

  Private Sub PnlEditar_Resize(sender As Object, e As EventArgs) Handles PnlEditar.Resize
    BtnAnadirConsulta.Location = New Point(BtnAnadirConsulta.Location.X, PnlEditar.Location.Y + PnlEditar.Size.Height + 4)
  End Sub

  Private Sub CargarInformes()
    CbInforme.DisplayMember = "Nombre"
    CbInforme.Items.Clear()

    Dim informes As IEnumerable(Of Informe) = db.Informes.ToList()
    For Each i In informes
      CbInforme.Items.Add(i)
    Next

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
    Using excelBuilder = New ExcelBuilder(informe.Nombre)
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
    BtnProgramar.Enabled = habilitado
    BtnAnadirConsulta.Enabled = habilitado
  End Sub

  Private Sub MinimizarEnAreaNotificacion()
    IconoNotificacion.Visible = True
    IconoNotificacion.ShowBalloonTip(1000)
    Hide()
  End Sub

  Private Function ValidarCambioInforme() As Boolean
    If informe IsNot Nothing AndAlso hayCambiosPendientes Then
      Dim resultado = MessageBox.Show("¿Desea guardar los cambios?", "Cambios en el informe", MessageBoxButtons.YesNoCancel)
      Select Case resultado
        Case DialogResult.Yes
          db.SaveChanges()
          Return True
        Case DialogResult.No
          db.Rollback()
          Return True
        Case DialogResult.Cancel
          Return False
      End Select
    End If
    Return True
  End Function

End Class
