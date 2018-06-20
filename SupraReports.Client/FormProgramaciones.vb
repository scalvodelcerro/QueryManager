Imports System.Data.Entity
Imports SupraReports.Model

Public Class FormProgramaciones
  Private db As SupraReportsContext = New SupraReportsContext()
  Private Sub FormProgramaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ProgramacionBindingSource.DataSource = db.Programaciones.Local.ToBindingList()
    db.Programaciones.Include("Informe").Load()
  End Sub

  Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
    GridProgramaciones.EndEdit()
    db.SaveChanges()
    db.Dispose()
  End Sub
End Class


Public Class DateTimePickerColumn
  Inherits DataGridViewColumn

  Public Sub New()
    MyBase.New(New DateTimePickerCell())
  End Sub

  Public Overrides Property CellTemplate As DataGridViewCell
    Get
      Return MyBase.CellTemplate
    End Get
    Set(value As DataGridViewCell)
      If value IsNot Nothing AndAlso
        Not value.GetType().IsAssignableFrom(GetType(DateTimePickerCell)) Then
        Throw New InvalidCastException("Must be a DateTimePickerCell")
      End If
      MyBase.CellTemplate = value
    End Set
  End Property
End Class

Public Class DateTimePickerCell
  Inherits DataGridViewTextBoxCell

  Public Sub New()
    MyBase.New()
    Style.Format = "HH:mm"
  End Sub

  Public Overrides Sub InitializeEditingControl(rowIndex As Integer, initialFormattedValue As Object, dataGridViewCellStyle As DataGridViewCellStyle)
    MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
    Dim control As DateTimePickerEditingControl = CType(DataGridView.EditingControl, DateTimePickerEditingControl)
    If Value Is Nothing Then
      control.Value = CType(DefaultNewRowValue, DateTime)
    Else
      Dim hora = CType(Value, DateTime)
      control.Value = DateTime.Today.AddHours(hora.Hour).AddMinutes(hora.Minute)
    End If
  End Sub

  Public Overrides ReadOnly Property EditType As Type
    Get
      Return GetType(DateTimePickerEditingControl)
    End Get
  End Property

  Public Overrides ReadOnly Property ValueType As Type
    Get
      Return GetType(DateTime)
    End Get
  End Property

  Public Overrides ReadOnly Property DefaultNewRowValue As Object
    Get
      Return DateTime.Now
    End Get
  End Property
End Class

Public Class DateTimePickerEditingControl
  Inherits DateTimePicker
  Implements IDataGridViewEditingControl

  Private dataGridView As DataGridView
  Private Shadows valueChanged As Boolean
  Private rowIndex As Integer

  Public Sub New()
    MyBase.New()
    Format = DateTimePickerFormat.Custom
    CustomFormat = "HH:mm"
    ShowUpDown = True
  End Sub

  Public Property EditingControlDataGridView As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
    Get
      Return dataGridView
    End Get
    Set(value As DataGridView)
      dataGridView = value
    End Set
  End Property

  Public Property EditingControlFormattedValue As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
    Get
      Return Value.ToString("HH:mm")
    End Get
    Set(value As Object)
      If value.GetType() = GetType(String) Then
        Try
          Me.Value = DateTime.Parse(value)
        Catch ex As Exception
          Me.Value = DateTime.Now
        End Try
      End If
    End Set
  End Property

  Public Property EditingControlRowIndex As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
    Get
      Return rowIndex
    End Get
    Set(value As Integer)
      rowIndex = value
    End Set
  End Property

  Public Property EditingControlValueChanged As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
    Get
      Return valueChanged
    End Get
    Set(value As Boolean)
      valueChanged = value
    End Set
  End Property

  Public ReadOnly Property EditingPanelCursor As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
    Get
      Return MyBase.Cursor
    End Get
  End Property

  Public ReadOnly Property RepositionEditingControlOnValueChange As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
    Get
      Return False
    End Get
  End Property

  Public Sub ApplyCellStyleToEditingControl(dataGridViewCellStyle As DataGridViewCellStyle) Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
    Font = dataGridViewCellStyle.Font
    CalendarForeColor = dataGridViewCellStyle.ForeColor
    CalendarMonthBackground = dataGridViewCellStyle.BackColor
  End Sub

  Public Sub PrepareEditingControlForEdit(selectAll As Boolean) Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
  End Sub

  Public Function EditingControlWantsInputKey(keyData As Keys, dataGridViewWantsInputKey As Boolean) As Boolean Implements IDataGridViewEditingControl.EditingControlWantsInputKey
    Select Case keyData And Keys.KeyCode
      Case Keys.Left, Keys.Up, Keys.Right, Keys.Down, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
        Return True
      Case Else
        Return Not dataGridViewWantsInputKey
    End Select
  End Function

  Public Function GetEditingControlFormattedValue(context As DataGridViewDataErrorContexts) As Object Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
    Return EditingControlFormattedValue
  End Function

  Protected Overrides Sub OnValueChanged(eventargs As EventArgs)
    valueChanged = True
    EditingControlDataGridView.NotifyCurrentCellDirty(True)
    MyBase.OnValueChanged(eventargs)
  End Sub
End Class