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
  End Sub

  Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
    Dim nombreInformeDialog As FormNombreInforme = New FormNombreInforme()

    If nombreInformeDialog.ShowDialog(Me) = DialogResult.OK Then
      informe = New Informe(nombreInformeDialog.TbNombre.Text, Environment.UserName)
      Dim consulta As Consulta = New Consulta(String.Empty, String.Empty, informe)
      informe.Consultas.Add(consulta)
      Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
        repo.Create(informe)
        repo.Save()
      End Using
      CbInforme.Items.Add(informe)
      CbInforme.SelectedItem = informe
      CargarConsultas()
    End If
  End Sub

  Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      repo.Update(informe)
      repo.Save()
    End Using
  End Sub

  Private Sub BtnGuardarComo_Click(sender As Object, e As EventArgs) Handles BtnGuardarComo.Click
    Dim nombreInformeDialog As FormNombreInforme = New FormNombreInforme()

    If nombreInformeDialog.ShowDialog(Me) = DialogResult.OK Then
      Dim nuevoInforme = New Informe(informe)
      nuevoInforme.Nombre = nombreInformeDialog.TbNombre.Text
      Using repo = New InformeRepository(New SupraReportsContext())
        repo.Create(nuevoInforme)
        repo.Save()
      End Using
      CbInforme.Items.Add(nuevoInforme)
      CbInforme.SelectedItem = nuevoInforme
      informe = nuevoInforme
      CargarConsultas()
    End If
  End Sub

  Private Sub BtnEliminarInforme_Click(sender As Object, e As EventArgs) Handles BtnEliminarInforme.Click
    Using repo = New InformeRepository(New SupraReportsContext())
      repo.Delete(informe)
      repo.Save()
    End Using
    CargarInformes()
    CargarConsultas()
  End Sub

  Private Sub BtnAnadirConsulta_Click(sender As Object, e As EventArgs) Handles BtnAnadirConsulta.Click
    Dim consulta As Consulta = New Consulta(String.Empty, String.Empty, informe)
    informe.Consultas.Add(consulta)
    Dim control As EditarConsultaUserControl = New EditarConsultaUserControl()
    control.Consulta = consulta
    PnlEditar.Controls.Add(control)
    PnlEditar.ScrollControlIntoView(control)
  End Sub

  Private Sub PnlEditar_Resize(sender As Object, e As EventArgs) Handles PnlEditar.Resize
    BtnAnadirConsulta.Location = New Point(BtnAnadirConsulta.Location.X, PnlEditar.Location.Y + PnlEditar.Size.Height + 4)
  End Sub

  Private Sub CargarInformes()
    CbInforme.DisplayMember = "Nombre"
    CbInforme.Items.Clear()
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      Dim informes As IEnumerable(Of Informe) = repo.FindAll()
      For Each i In informes
        CbInforme.Items.Add(i)
      Next
    End Using
    CbInforme.SelectedItem = Nothing
    CbInforme.Text = String.Empty
  End Sub

  Private Sub CargarConsultas()
    PnlEditar.Controls.Clear()
    If informe IsNot Nothing Then
      For Each consulta In informe.Consultas
        Dim control As EditarConsultaUserControl = New EditarConsultaUserControl()
        control.Consulta = consulta
        PnlEditar.Controls.Add(control)
      Next
    End If
  End Sub

End Class
