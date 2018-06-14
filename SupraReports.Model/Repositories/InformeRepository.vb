﻿Imports System.Data.Entity

Public NotInheritable Class InformeRepository
  Implements IDisposable

  Public Shared ReadOnly Property Instance As InformeRepository
    Get
      If _instance Is Nothing Then _instance = New InformeRepository(New SupraReportsContext())
      Return _instance
    End Get
  End Property
  Private Shared _instance As InformeRepository

  Private Sub New(db As SupraReportsContext)
    Me.db = db
  End Sub
  Private db As SupraReportsContext

  Public Sub Save()
    db.SaveChanges()
    db.LimpiarEstadoEntidades()
  End Sub

  Public Sub Create(informe As Informe)
    db.Informes.Add(informe)
  End Sub

  Public Function FindAll() As IEnumerable(Of Informe)
    Return db.Informes.ToList()
  End Function

  Public Sub Update(informe As Informe)
    db.FixState()
  End Sub

  Public Sub Delete(informe As Informe)
    For Each c In informe.ObtenerConsultasSinEliminar()
      If c.Id = 0 Then
        db.Entry(c).State = EntityState.Added
      End If
    Next
    db.Informes.Attach(informe)
    db.Informes.Remove(informe)
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
