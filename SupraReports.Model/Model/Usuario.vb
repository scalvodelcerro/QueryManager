Public Class Usuario
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Protected Sub New()
    End Sub

    Public Property Nombre As String
    Public Property MaximoNumeroFilasConsulta As Integer
    Public Property RutaFicheroDefecto As String

    Public Overridable Property Informes As ICollection(Of Informe)
    Public Overridable Property Permisos As ICollection(Of PermisoUsuario)
    Public Overridable Property ConfiguracionesInforme As ICollection(Of ConfiguracionInforme)
End Class
