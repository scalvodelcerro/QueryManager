Public Class Parametro

  Public Shared Function Crear(nombre As String, valor As String, consulta As Consulta) As Parametro
    Return New Parametro(nombre, valor, consulta)
  End Function

  Public Shared Function Copiar(parametro As Parametro) As Parametro
    Dim copiaParametro As Parametro = Crear(parametro.Nombre, parametro.Valor, Nothing)
    Return copiaParametro
  End Function

  Protected Sub New()
  End Sub

  Private Sub New(nombre As String, valor As String, consulta As Consulta)
    Me.Nombre = nombre
    Me.Valor = valor
    Me.Consulta = consulta
  End Sub

  Public Property Id As Integer
  Public Overridable Property Nombre As String
  Public Overridable Property Valor As String
  Public Property Consulta As Consulta

  Public MustInherit Class ParametroDefecto

    Public MustOverride ReadOnly Property NombreParametro As String
    Public MustOverride ReadOnly Property Valor As String

    Private Shared _parametros As IEnumerable(Of ParametroDefecto) =
      New List(Of ParametroDefecto)() From {
        New ParametroDefectoHoy(),
        New ParametroDefectoAyer()
      }

    Public Shared ReadOnly Property Todos As IEnumerable(Of ParametroDefecto)
      Get
        Return _parametros
      End Get
    End Property

    Public Shared ReadOnly Property Lookup(nombre As String) As ParametroDefecto
      Get
        Return _parametros.SingleOrDefault(Function(x) x.NombreParametro.ToUpper() = nombre.ToUpper())
      End Get
    End Property

    Private NotInheritable Class ParametroDefectoHoy
      Inherits ParametroDefecto

      Public Overrides ReadOnly Property NombreParametro As String
        Get
          Return "HOY"
        End Get
      End Property

      Public Overrides ReadOnly Property Valor As String
        Get
          Return DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss")
        End Get
      End Property
    End Class

    Private NotInheritable Class ParametroDefectoAyer
      Inherits ParametroDefecto

      Public Overrides ReadOnly Property NombreParametro As String
        Get
          Return "AYER"
        End Get
      End Property

      Public Overrides ReadOnly Property Valor As String
        Get
          Return DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss")
        End Get
      End Property
    End Class
  End Class

End Class
