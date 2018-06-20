Public Class ProgramacionRepository
  Inherits BaseRepository

  Public Sub Create(programacion As Programacion)
    db.Programaciones.Add(programacion)
  End Sub

  Public Function FindAll() As IEnumerable(Of Programacion)
    Return db.Programaciones.AsEnumerable()
  End Function

  Public Function FindByIdInforme(idInforme As Integer) As IEnumerable(Of Programacion)
    Return db.Programaciones.Where(Function(x) x.Informe.Id = idInforme).AsEnumerable()
  End Function

  Public Sub Delete(programacion As Programacion)
    db.Programaciones.Remove(programacion)
  End Sub
End Class
