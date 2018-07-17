﻿Public Class Informe
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
        Programacion = New Programacion()
        Consultas = New List(Of Consulta)()
        Ejecuciones = New List(Of Ejecucion)()
    End Sub

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property NombreUsuario As String
    Public Property UsuarioCreacion As Usuario
    Public Overridable Property Proyecto As Proyecto
    Public Overridable Property Programacion As Programacion
    Public Overridable Property Consultas As ICollection(Of Consulta)
    Public Overridable Property Ejecuciones As ICollection(Of Ejecucion)
    Public Overridable Property Configuraciones As ICollection(Of ConfiguracionInforme)

    Public Sub AnadirConsulta(consulta As Consulta)
        consulta.Informe = Me
        Consultas.Add(consulta)
    End Sub

    Public Sub AnadirEjecucion(resultado As String, rutaFichero As String, nombreUsuario As String)
        Ejecuciones.Add(Ejecucion.Crear(resultado, rutaFichero, nombreUsuario, Me))
    End Sub

    Sub ActualizarValorParametro(nombreParametro As String, valorParametro As String)

        Dim parametros = Consultas.SelectMany(Function(x) x.Parametros.Where(Function(xx) xx.Nombre = nombreParametro))
        For Each p In parametros
            p.Valor = valorParametro
        Next
    End Sub

End Class