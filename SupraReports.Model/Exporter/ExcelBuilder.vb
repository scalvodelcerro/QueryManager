Imports System.IO
Imports System.Reflection
Imports OfficeOpenXml

Public Class ExcelBuilder
  Implements IDisposable

  Public Sub New(outputFile As String)
    excel = New ExcelPackage(New FileInfo(outputFile))
  End Sub

  Private excel As ExcelPackage

  Public Function AddWorksheet(worksheetName As String, contents As DataTable, messages As IEnumerable(Of String)) As ExcelBuilder
    If String.IsNullOrEmpty(worksheetName) Then worksheetName = String.Format("sheet_{0}", excel.Workbook.Worksheets.Count)
    Dim worksheet = excel.Workbook.Worksheets.Add(worksheetName.Replace(" ", "_"))
    Dim contentsRowStart = 1
    If messages IsNot Nothing AndAlso messages.Any() Then
      worksheet.Cells("A1").LoadFromCollection(messages, False, Table.TableStyles.Medium13)
      contentsRowStart = messages.Count() + 2
    End If
    If contents IsNot Nothing Then
      worksheet.Cells(contentsRowStart, 1).LoadFromDataTable(contents, True, Table.TableStyles.Medium13)
    End If
    Return Me
  End Function

  Public Sub Build()
    If excel.Workbook.Worksheets.Any() Then
      excel.Save()
    End If
  End Sub

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
