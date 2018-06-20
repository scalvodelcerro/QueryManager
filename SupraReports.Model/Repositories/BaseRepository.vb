Public MustInherit Class BaseRepository
  Implements IDisposable

  Protected db As SupraReportsContext

  Public Sub New()
    db = New SupraReportsContext()
  End Sub

  Public Sub Save()
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
  End Sub
#End Region

End Class
