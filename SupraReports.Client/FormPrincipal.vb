Imports SupraReports.Model

Public Class FormPrincipal
  Private informe As Informe

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
    informe = New Informe(Environment.UserName)
    Dim consulta As Consulta = New Consulta(String.Empty, String.Empty, informe)
    informe.Consultas.Add(consulta)
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      repo.Create(informe)
    End Using
    CbInforme.Items.Add(informe)
    CbInforme.SelectedItem = informe
    CbInformeUsar.Items.Add(informe)
    CargarConsultas()
  End Sub

  Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      repo.Update(informe)
    End Using
  End Sub

  Private Sub BtnAnadirConsulta_Click(sender As Object, e As EventArgs) Handles BtnAnadirConsulta.Click
    Dim consulta = New Consulta(String.Empty, String.Empty, informe)
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      repo.Create(consulta)
    End Using
    CargarConsultas()
  End Sub

  Private Sub CbInformeUsar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbInformeUsar.SelectedIndexChanged
    PnlUsar.Controls.Clear()
    If CbInformeUsar.SelectedItem IsNot Nothing Then
      informe = CType(CbInformeUsar.SelectedItem, Informe)
      CargarConsultasUsar()
    End If
  End Sub

  Private Sub CargarInformes()
    CbInforme.DisplayMember = "Id"
    CbInforme.Items.Clear()
    CbInformeUsar.DisplayMember = "Id"
    CbInformeUsar.Items.Clear()
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      Dim informes As IEnumerable(Of Informe) = repo.FindAll()
      For Each i In informes
        CbInforme.Items.Add(i)
        CbInformeUsar.Items.Add(i)
      Next
    End Using
  End Sub

  Private Sub CargarConsultas()
    PnlEditar.Controls.Clear()
    For Each consulta In informe.Consultas.Reverse()
      Dim control As EditarConsultaUserControl = New EditarConsultaUserControl()
      control.Consulta = consulta
      PnlEditar.Controls.Add(control)
    Next
  End Sub

  Private Sub CargarConsultasUsar()
    PnlUsar.Controls.Clear()
    For Each consulta In informe.Consultas.Reverse()
      Dim control As UsarConsultaUserControl = New UsarConsultaUserControl()
      control.Consulta = consulta
      PnlUsar.Controls.Add(control)
    Next
  End Sub

End Class
