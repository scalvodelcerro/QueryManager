Imports System.Data.Entity

Public Class InformeRepository
  Implements IDisposable

  Private db As SupraReportsContext

  Public Sub New(db As SupraReportsContext)
    Me.db = db
  End Sub

  Public Sub Save()
    db.SaveChanges()
  End Sub

  Public Sub Create(informe As Informe)
    db.Informes.Add(informe)
  End Sub

  Public Sub Create(consulta As Consulta)
    db.Informes.Attach(consulta.Informe)
    consulta.Informe = Nothing
    db.Consultas.Add(consulta)
  End Sub

  Public Sub Create(parametro As Parametro)
    db.Consultas.Attach(parametro.Consulta)
    parametro.Consulta = Nothing
    db.Parametros.Add(parametro)
  End Sub

  Public Function FindAll() As IEnumerable(Of Informe)
    Return db.Informes.
        Include("Consultas.Parametros").
        ToList()
  End Function

  Public Sub Update(informe As Informe)
    For Each c In informe.Consultas.Where(Function(x) x.Id = 0)
      db.Entry(c).State = EntityState.Added
    Next
    For Each c In informe.Consultas.Where(Function(x) x.Id <> 0)
      Update(c)
    Next
    db.Informes.Attach(informe)
    db.Entry(informe).State = EntityState.Modified
  End Sub

  Public Sub Update(consulta As Consulta)
    For Each p In consulta.Parametros.Where(Function(x) x.Id = 0)
      db.Entry(p).State = EntityState.Added
    Next
    For Each p In consulta.Parametros.Where(Function(x) x.Id <> 0)
      Update(p)
    Next
    db.Consultas.Attach(consulta)
    db.Entry(consulta).State = EntityState.Modified
  End Sub

  Public Sub Update(parametro As Parametro)
    db.Entry(parametro).State = EntityState.Modified
  End Sub

  Public Sub Delete(informe As Informe)
    For Each c In informe.Consultas
      If c.Id = 0 Then
        db.Entry(c).State = EntityState.Added
      End If
    Next
    db.Informes.Attach(informe)
    db.Informes.Remove(informe)
  End Sub

  Public Sub Delete(consulta As Consulta)
    If consulta.Id = 0 Then
      consulta.Informe.Consultas.Remove(consulta)
    Else
      db.Informes.Attach(consulta.Informe)
      db.Consultas.Remove(consulta)
    End If
  End Sub

  Public Sub Delete(parametro As Parametro)
    If parametro.Id = 0 Then
      parametro.Consulta.Parametros.Remove(parametro)
    Else
      db.Consultas.Attach(parametro.Consulta)
      db.Parametros.Remove(parametro)
    End If
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
  End Sub
#End Region
End Class
