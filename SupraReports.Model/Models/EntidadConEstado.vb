Public MustInherit Class EntidadConEstado
  Public Property Estado As EstadoEntidad
    Get
      Return _estado
    End Get
    Private Set(value As EstadoEntidad)
      _estado = value
    End Set
  End Property
  Private _estado As EstadoEntidad

  Protected Sub MarcarComoNuevo()
    Estado = EstadoEntidad.Nuevo
  End Sub

  Protected Sub MarcarModificadoSiNoNuevo()
    If Estado <> EstadoEntidad.Nuevo Then
      Estado = EstadoEntidad.Modificado
    End If
  End Sub

  Public Sub MarcarComoSinCambios()
    Estado = EstadoEntidad.SinCambios
  End Sub

  Public Sub MarcarComoEliminado()
    Estado = EstadoEntidad.Eliminado
  End Sub
End Class

Public Enum EstadoEntidad
  SinCambios
  Nuevo
  Modificado
  Eliminado
End Enum
