Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports MySql.Data.EntityFramework

<DbConfigurationType(GetType(MySqlEFConfiguration))>
Public Class SupraReportsContext
  Inherits DbContext

  Public Property Informes As DbSet(Of Informe)
  Public Property Consultas As DbSet(Of Consulta)
  Public Property Parametros As DbSet(Of Parametro)

  Public Sub New()
    MyBase.New("name=SupraReports")
    Database.CreateIfNotExists()
  End Sub
End Class

<Table("Informe")>
Public Class Informe
  Public Sub New(nombre As String, usuario As String)
    Me.Nombre = nombre
    Me.Usuario = usuario
    Consultas = New List(Of Consulta)()
  End Sub

  Public Sub New(informe As Informe)
    Me.New(informe.Nombre, informe.Usuario)
    For Each c In informe.Consultas
      Dim newC = New Consulta(c) With {
        .Informe = Me,
        .IdInforme = Id
      }
      Consultas.Add(newC)
    Next
  End Sub

  Protected Sub New()
  End Sub

  <Key, Column("Id_Informe")>
  Public Property Id As Integer
  <Required>
  Public Property Nombre As String
  Public Property Usuario As String
  Public Overridable Property Consultas As ICollection(Of Consulta)
End Class

<Table("Consulta")>
Public Class Consulta
  Public Sub New(nombre As String, textoSql As String, informe As Informe)
    Me.Nombre = nombre
    Me.TextoSql = textoSql
    Me.Informe = informe
    IdInforme = informe.Id
    Parametros = New List(Of Parametro)()
  End Sub

  Public Sub New(consulta As Consulta)
    Me.New(consulta.Nombre, consulta.TextoSql, consulta.Informe)
    For Each p In consulta.Parametros
      Dim newP = New Parametro(p) With {
        .Consulta = Me,
        .IdConsulta = Id
      }
      Parametros.Add(newP)
    Next
  End Sub

  Protected Sub New()
  End Sub

  <Key, Column("Id_Consulta")>
  Public Property Id As Integer
  <StringLength(100)>
  Public Property Nombre As String
  <Column("Texto_Sql", TypeName:="Text"), StringLength(50000)>
  Public Property TextoSql As String
  <Column("Id_Informe"), ForeignKey("Informe")>
  Public Property IdInforme As Integer
  Public Overridable Property Informe As Informe
  Public Overridable Property Parametros As ICollection(Of Parametro)
End Class

<Table("Parametro")>
Public Class Parametro
  Public Sub New(nombre As String, valor As String, consulta As Consulta)
    Me.Nombre = nombre
    Me.Valor = valor
    Me.Consulta = consulta
    IdConsulta = consulta.Id
  End Sub

  Public Sub New(parametro As Parametro)
    Me.New(parametro.Nombre, parametro.Valor, parametro.Consulta)
  End Sub

  Protected Sub New()
  End Sub

  <Key, Column("Id_Parametro")>
  Public Property Id As Integer
  <Required, StringLength(100)>
  Public Property Nombre As String
  <StringLength(1000)>
  Public Property Valor As String
  <Column("Id_Consulta"), ForeignKey("Consulta"), Required>
  Public Property IdConsulta As Integer
  Public Property Consulta As Consulta
End Class
