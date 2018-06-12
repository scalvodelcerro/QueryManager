Imports System.Data.Entity

Public Class InformeRepository
  Implements IDisposable

  Private db As SupraReportsContext

  Public Sub New(db As SupraReportsContext)
    Me.db = db
  End Sub

  Public Sub Create(informe As Informe)
    informe = db.Informes.Add(informe)
    db.SaveChanges()
  End Sub

  Public Sub Create(consulta As Consulta)
    db.Informes.Attach(consulta.Informe)
    consulta.Informe = Nothing
    db.Consultas.Add(consulta)
    'Dim d = db.Consultas.Find(consulta.Id)
    db.SaveChanges()
  End Sub

  Public Function FindAll() As IEnumerable(Of Informe)
    Return db.Informes.
        Include("Consultas.Parametros").
        ToList()
  End Function

  Public Sub Update(informe As Informe)
    db.Entry(informe).State = EntityState.Modified
    For Each c In informe.Consultas
      Update(c)
    Next
    db.SaveChanges()
  End Sub

  Public Sub Update(consulta As Consulta)
    db.Entry(consulta).State = EntityState.Modified
    For Each p In consulta.Parametros
      Update(p)
    Next
    db.SaveChanges()
  End Sub

  Public Sub Update(parametro As Parametro)
    db.Entry(parametro).State = EntityState.Modified
    db.SaveChanges()
  End Sub

  Public Sub Delete(consulta As Consulta)
    db.Informes.Attach(consulta.Informe)
    db.Entry(consulta).State = EntityState.Deleted
    db.SaveChanges()
  End Sub

#Region "IDisposable Support"
  Private disposedValue As Boolean

  Protected Overridable Sub Dispose(disposing As Boolean)
    If Not disposedValue Then
      If disposing Then
        db.Dispose()
      End If
    End If
    disposedValue = True
  End Sub

  Public Sub Dispose() Implements IDisposable.Dispose
    Dispose(True)
    ' GC.SuppressFinalize(Me)
  End Sub
#End Region
End Class
