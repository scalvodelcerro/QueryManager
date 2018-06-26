Public Class Informe
  Public Shared Function Crear(nombre As String, usuario As String) As Informe
    Dim informe As Informe = New Informe(nombre, usuario)
    Return informe
  End Function

  Public Shared Function Copiar(informe As Informe) As Informe
    Dim copiaInforme As Informe = Crear(informe.Nombre, informe.Usuario)
    For Each c In informe.Consultas
      Dim copiaConsulta As Consulta = Consulta.Copiar(c)
      copiaInforme.AnadirConsulta(copiaConsulta)
    Next
    Return copiaInforme
  End Function

  Protected Sub New()
  End Sub

  Private Sub New(nombre As String, usuario As String)
    Me.Nombre = nombre
    Me.Usuario = usuario
    Programacion = New Programacion()
    Consultas = New List(Of Consulta)()
    Ejecuciones = New List(Of Ejecucion)()
  End Sub

  Public Property Id As Integer
  Public Property Nombre As String
  Public Property Usuario As String
  Public Overridable Property Proyecto As Proyecto
  Public Overridable Property Programacion As Programacion
  Public Overridable Property Consultas As ICollection(Of Consulta)
  Public Overridable Property Ejecuciones As ICollection(Of Ejecucion)

  Public Sub AnadirConsulta(consulta As Consulta)
    consulta.Informe = Me
    Consultas.Add(consulta)
  End Sub

  Public Sub AnadirEjecucion(horaProgramada As String, resultado As String, rutaFichero As String)
    Ejecuciones.Add(Ejecucion.Crear(horaProgramada, resultado, rutaFichero, Me))
  End Sub

End Class