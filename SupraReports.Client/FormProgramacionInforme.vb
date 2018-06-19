Imports SupraReports.Model

Public Class FormProgramacionInforme
  Public Sub New(programacion As Programacion)
    InitializeComponent()

    If programacion IsNot Nothing Then
      PickerHora.Value = DateTime.Parse(programacion.Hora)
      CbLunes.Checked = programacion.Lunes
      CbMartes.Checked = programacion.Martes
      CbMiercoles.Checked = programacion.Miercoles
      CbJueves.Checked = programacion.Jueves
      CbViernes.Checked = programacion.Viernes
      CbSabado.Checked = programacion.Sabado
      CbDomingo.Checked = programacion.Domingo
    End If
  End Sub
End Class