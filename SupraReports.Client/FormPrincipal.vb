Imports SupraReports.Model

Public Class FormPrincipal
  Private informe As Informe
  Private Const PatternParametro = "#(\w+)#"

  Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    CargarInformes()
  End Sub

  Private Sub CbInforme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbInforme.SelectedIndexChanged
    PnlEditar.Controls.Clear()
    If CbInforme.SelectedItem IsNot Nothing Then
      informe = CType(CbInforme.SelectedItem, Informe)
      CargarConsultas()
    End If
    EstablecerEstadoBotones()
  End Sub

  Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
    Dim nombreInformeDialog As FormNombreInforme = New FormNombreInforme()

    If nombreInformeDialog.ShowDialog(Me) = DialogResult.OK Then
      informe = New Informe(nombreInformeDialog.TbNombre.Text, Environment.UserName)
      informe.AnadirConsulta(New Consulta(String.Empty, String.Empty, informe))

      InformeRepository.Instance.Create(informe)
      InformeRepository.Instance.Save()

      CbInforme.Items.Add(informe)
      CbInforme.SelectedItem = informe
      CargarConsultas()
      EstablecerEstadoBotones()
    End If
  End Sub

  Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    InformeRepository.Instance.Update(informe)
    InformeRepository.Instance.Save()
  End Sub

  Private Sub BtnGuardarComo_Click(sender As Object, e As EventArgs) Handles BtnGuardarComo.Click
    Dim nombreInformeDialog As FormNombreInforme = New FormNombreInforme()

    If nombreInformeDialog.ShowDialog(Me) = DialogResult.OK Then
      Dim nuevoInforme = New Informe(informe)

      InformeRepository.Instance.Create(nuevoInforme)
      InformeRepository.Instance.Save()

      CbInforme.Items.Add(nuevoInforme)
      CbInforme.SelectedItem = nuevoInforme
      informe = nuevoInforme
      CargarConsultas()
    End If
  End Sub

  Private Sub BtnEliminarInforme_Click(sender As Object, e As EventArgs) Handles BtnEliminarInforme.Click
    InformeRepository.Instance.Delete(informe)
    InformeRepository.Instance.Save()

    informe = Nothing
    CargarInformes()
    CargarConsultas()
    EstablecerEstadoBotones()
  End Sub

  Private Sub BtnAnadirConsulta_Click(sender As Object, e As EventArgs) Handles BtnAnadirConsulta.Click
    Dim consulta As Consulta = New Consulta(String.Empty, String.Empty, informe)
    informe.AnadirConsulta(consulta)
    Dim control As EditarConsultaUserControl = New EditarConsultaUserControl(consulta)
    PnlEditar.Controls.Add(control)
    PnlEditar.ScrollControlIntoView(control)
  End Sub

  Private Sub PnlEditar_Resize(sender As Object, e As EventArgs) Handles PnlEditar.Resize
    BtnAnadirConsulta.Location = New Point(BtnAnadirConsulta.Location.X, PnlEditar.Location.Y + PnlEditar.Size.Height + 4)
  End Sub

  Private Sub CargarInformes()
    CbInforme.DisplayMember = "Nombre"
    CbInforme.Items.Clear()

    Dim informes As IEnumerable(Of Informe) = InformeRepository.Instance.FindAll()
    For Each i In informes
      CbInforme.Items.Add(i)
    Next

    CbInforme.SelectedItem = Nothing
    CbInforme.Text = String.Empty
  End Sub

  Private Sub CargarConsultas()
    PnlEditar.Controls.Clear()
    If informe IsNot Nothing Then
      For Each consulta In informe.ObtenerConsultasSinEliminar()
        Dim control As EditarConsultaUserControl = New EditarConsultaUserControl(consulta)
        PnlEditar.Controls.Add(control)
      Next
    End If
  End Sub

  Private Sub EstablecerEstadoBotones()
    Dim habilitado As Boolean = informe IsNot Nothing
    BtnGuardar.Enabled = habilitado
    BtnGuardarComo.Enabled = habilitado
    BtnEliminarInforme.Enabled = habilitado
    BtnAnadirConsulta.Enabled = habilitado
  End Sub

  Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    InformeRepository.Instance.Dispose()
  End Sub
End Class
