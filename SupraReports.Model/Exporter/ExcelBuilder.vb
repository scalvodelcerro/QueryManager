Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Table

Public Class ExcelBuilder
  Implements IDisposable

  Public Sub New(outputFile As String)
    excel = New ExcelPackage(New FileInfo(outputFile))
  End Sub

  Private excel As ExcelPackage

  Public Function AddWorksheet(worksheetName As String, content As DataTable, messages As IEnumerable(Of String)) As ExcelBuilder
    Dim worksheet = excel.Workbook.Worksheets.Add(FormatWorksheetName(worksheetName))
    AddMessages(worksheet, messages)
    AddContent(worksheet, content)
    Return Me
  End Function

  Private Sub AddMessages(worksheet As ExcelWorksheet, messages As IEnumerable(Of String))
    If messages IsNot Nothing AndAlso messages.Any() Then
      Dim emptyRowNumber = FindEmptyRowNumber(worksheet)
      Dim rng As ExcelRangeBase = worksheet.Cells(emptyRowNumber, 1).LoadFromCollection(messages, False)
      Dim table = worksheet.Tables.Add(rng, String.Format("{0}_messages", worksheet.Name))
      table.TableStyle = TableStyles.Medium13
    End If
  End Sub

  Private Sub AddContent(worksheet As ExcelWorksheet, content As DataTable)
    If content IsNot Nothing Then
      Dim emptyRowNumber = FindEmptyRowNumber(worksheet)
      Dim rng = worksheet.Cells(FindEmptyRowNumber(worksheet), 1).LoadFromDataTable(content, True)
      Dim table = worksheet.Tables.Add(rng, String.Format("{0}_contents", worksheet.Name))
      table.TableStyle = TableStyles.Medium13
    End If
  End Sub

  Private Function FormatWorksheetName(worksheetName As String) As String
    If String.IsNullOrEmpty(worksheetName) Then worksheetName = String.Format("sheet_{0}", excel.Workbook.Worksheets.Count)
    worksheetName = worksheetName.Replace(" ", "_")
    Dim worksheetNameBase = worksheetName
    Dim i As Integer = 1
    While (excel.Workbook.Worksheets.Any(Function(ws) ws.Name = worksheetName))
      worksheetName = String.Format("{0}_{1}", worksheetNameBase, i)
      i += 1
    End While
    Return worksheetName
  End Function

  Public Sub Build()
    If excel.Workbook.Worksheets.Any() Then
      excel.Save()
    End If
  End Sub

  Private Function FindEmptyRowNumber(worksheet As ExcelWorksheet) As Integer
    If worksheet.Dimension Is Nothing Then Return 1
    Return worksheet.Dimension.End.Row + 2
  End Function

#Region "IDisposable"
  Private disposedValue As Boolean

  Protected Overridable Sub Dispose(disposing As Boolean)
    If Not disposedValue Then
      If disposing Then
        excel.Dispose()
      End If
    End If
    disposedValue = True
  End Sub

  Public Sub Dispose() Implements IDisposable.Dispose
    Dispose(True)
  End Sub
#End Region
End Class
