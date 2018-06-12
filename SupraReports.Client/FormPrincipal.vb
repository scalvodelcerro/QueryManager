Imports System.Text.RegularExpressions
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
    informe = New Informe(Environment.UserName)
    Dim consulta As Consulta = New Consulta(String.Empty, String.Empty, informe)
    informe.Consultas.Add(consulta)
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      repo.Create(informe)
      repo.Save()
    End Using
    CbInforme.Items.Add(informe)
    CbInforme.SelectedItem = informe
    CbInformeUsar.Items.Add(informe)
    CargarConsultas()
  End Sub

  Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      For Each c In informe.Consultas
        Dim nombresParametros = Regex.Matches(c.TextoSql, PatternParametro).Cast(Of Match).Select(Function(x) x.Groups(1).Value.ToUpper()).Distinct()
        Dim eliminados = c.Parametros.Where(Function(x) Not nombresParametros.Contains(x.Nombre)).ToList()
        For Each p In eliminados
          repo.Delete(p)
        Next
        For Each nombreParametro In nombresParametros.Except(c.Parametros.Select(Function(x) x.Nombre))
          repo.Create(New Parametro(nombreParametro, String.Empty, c))
          repo.Save()
        Next
      Next
      repo.Update(informe)
      repo.Save()
    End Using
  End Sub

  Private Sub BtnAnadirConsulta_Click(sender As Object, e As EventArgs) Handles BtnAnadirConsulta.Click
    Using repo As InformeRepository = New InformeRepository(New SupraReportsContext())
      repo.Create(New Consulta(String.Empty, String.Empty, informe))
      repo.Save()
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

  Private Sub Tabs_Selected(sender As Object, e As TabControlEventArgs) Handles Tabs.Selected
    If informe IsNot Nothing Then
      Select Case e.TabPageIndex
        Case TabCrear.TabIndex
          CargarConsultas()
        Case TabUsar.TabIndex
          CargarConsultasUsar()
      End Select
    End If
  End Sub
End Class
