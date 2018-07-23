Public Class Informe
  Public Shared Function Crear(nombre As String, usuario As String) As Informe
    Dim informe As Informe = New Informe(nombre, usuario)
    Return informe
  End Function

  Public Shared Function Copiar(informe As Informe) As Informe
    Dim copiaInforme As Informe = Crear(informe.Nombre, informe.NombreUsuario)
    For Each c In informe.Consultas
      Dim copiaConsulta As Consulta = Consulta.Copiar(c)
      copiaInforme.AnadirConsulta(copiaConsulta)
    Next
    Return copiaInforme
  End Function

  Protected Sub New()
  End Sub

  Private Sub New(nombre As String, nombreUsuario As String)
    Me.Nombre = nombre
    Me.NombreUsuario = nombreUsuario
    Consultas = New List(Of Consulta)()
  End Sub

  Public Property Id As Integer
  Public Property Nombre As String
  Public Property NombreUsuario As String
  Public Overridable Property UsuarioCreacion As Usuario
  Public Overridable Property Proyecto As Proyecto
  Public Overridable Property Consultas As ICollection(Of Consulta)

  Public Sub AnadirConsulta(consulta As Consulta)
    consulta.Informe = Me
    Consultas.Add(consulta)
  End Sub

  Sub ActualizarValorParametro(nombreParametro As String, valorParametro As String)
    Dim parametros = Consultas.SelectMany(Function(x) x.Parametros.Where(Function(xx) xx.Nombre = nombreParametro))
    For Each p In parametros
      p.Valor = valorParametro
    Next
  End Sub

End Class