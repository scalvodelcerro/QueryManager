Imports System.IO
Imports System.Reflection
Imports OfficeOpenXml

Public Class ExcelBuilder
  Implements IDisposable

  Public Sub New(outputFile As String)
    excel = New ExcelPackage(New FileInfo(outputFile))
  End Sub

  Private excel As ExcelPackage

  Public Function AddWorksheet(worksheetName As String, contents As IDataReader) As ExcelBuilder
    If String.IsNullOrEmpty(worksheetName) Then worksheetName = String.Format("sheet_{0}", excel.Workbook.Worksheets.Count)
    Dim worksheet = excel.Workbook.Worksheets.Add(worksheetName.Replace(" ", "_"))
    If contents IsNot Nothing Then
      worksheet.Cells("A1").LoadFromDataReader(contents, True, worksheet.Name, Table.TableStyles.Medium10)
    End If
    Return Me
  End Function

  Public Function AddWorksheet(worksheetName As String, contents As IEnumerable(Of Exception)) As ExcelBuilder
    If String.IsNullOrEmpty(worksheetName) Then worksheetName = String.Format("sheet_{0}", excel.Workbook.Worksheets.Count)
    Dim worksheet = excel.Workbook.Worksheets.Add(worksheetName.Replace(" ", "_"))
    If contents IsNot Nothing Then
      Dim mi As MemberInfo() = GetType(Exception).GetProperties().
        Where(Function(pi) pi.Name = "Message").
        Select(Function(pi) CType(pi, MemberInfo)).
        ToArray()

      worksheet.Cells("A1").LoadFromCollection(contents, True, Table.TableStyles.Medium10, Nothing, mi)
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
