Imports System.Data.Entity

Public Class InformeRepository
  Inherits BaseRepository

  Public Sub Create(informe As Informe)
    db.Informes.Add(informe)
  End Sub

  Public Function FindAll() As IEnumerable(Of Informe)
    Return db.Informes.Include("Consultas.Parametros").AsNoTracking().ToList()
  End Function

  Public Function FindById(idInforme As Integer) As Informe
    Return db.Informes.AsNoTracking().SingleOrDefault(Function(x) x.Id = idInforme)
  End Function

  Public Sub Update(informe As Informe)
    Dim informeEntity = db.Informes.Include("Consultas").Single(Function(x) x.Id = informe.Id)
    For Each consultaEntity In informeEntity.Consultas.ToList()
      Dim consulta = informe.Consultas.SingleOrDefault(Function(x) x.Id = consultaEntity.Id)
      If consulta Is Nothing Then
        informeEntity.Consultas.Remove(consultaEntity)
        db.Consultas.Remove(consultaEntity)
      Else
        consultaEntity.Nombre = consulta.Nombre
        consultaEntity.TextoSql = consulta.TextoSql
      End If
    Next
    For Each consulta In informe.Consultas.Where(Function(x) x.Id = 0).ToList()
      consulta.Informe = informeEntity
      db.Consultas.Add(consulta)
    Next

    'informeEntity.Consultas = consultaEntities
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
End Class
