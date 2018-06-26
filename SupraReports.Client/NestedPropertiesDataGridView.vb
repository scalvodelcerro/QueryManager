Imports System.Reflection

Public Class NestedPropertiesDataGridView
  Private Sub NestedPropertiesDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MyBase.CellFormatting
    If Rows(e.RowIndex).DataBoundItem IsNot Nothing AndAlso
        Columns(e.ColumnIndex).DataPropertyName.Contains(".") Then
      e.Value = BindProperty(Rows(e.RowIndex).DataBoundItem,
                             Columns(e.ColumnIndex).DataPropertyName)
    End If
  End Sub

  Private Function BindProperty(item As Object, propertyName As String) As Object
    Dim valorRetorno As Object = String.Empty
    If item IsNot Nothing Then
      If propertyName.Contains(".") Then
        Dim arrayProperties As PropertyInfo() = item.GetType().GetProperties()
        Dim leftPropertyName As String = propertyName.Split(".").First()

        For Each propertyInfo In arrayProperties
          If propertyInfo.Name = leftPropertyName Then
            valorRetorno = BindProperty(propertyInfo.GetValue(item),
                              propertyName.Substring(propertyName.IndexOf(".") + 1))
          End If
        Next
      Else
        valorRetorno = item.GetType().GetProperty(propertyName).GetValue(item)
      End If
    End If
    Return valorRetorno
  End Function
End Class
