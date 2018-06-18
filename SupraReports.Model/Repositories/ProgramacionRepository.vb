Public Class ProgramacionRepository
  Implements IDisposable

  Public Shared ReadOnly Property Instance As ProgramacionRepository
    Get
      If _instance Is Nothing Then _instance = New ProgramacionRepository(SupraReportsContext.Instance)
      Return _instance
    End Get
  End Property
  Private Shared _instance As ProgramacionRepository

  Private Sub New(db As SupraReportsContext)
    Me.db = db
  End Sub
  Private db As SupraReportsContext

  Public Sub Save()
    db.SaveChanges()
    db.LimpiarEstadoEntidades()
  End Sub

  Public Sub Create(programacion As Programacion)
    db.Programaciones.Add(programacion)
  End Sub

  Public Function FindByIdInforme(idInforme As Integer) As IEnumerable(Of Programacion)
    Return db.Programaciones.Where(Function(x) x.IdInforme = idInforme).AsEnumerable()
  End Function

  Public Sub Delete(programacion As Programacion)
    db.Programaciones.Remove(programacion)
  End Sub

#Region "IDisposable Support"
  Private disposedValue As Boolean

  Protected Sub Dispose(disposing As Boolean)
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
