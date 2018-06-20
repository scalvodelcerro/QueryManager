Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Consulta",
                Function(c) New With
                    {
                        .Id_Consulta = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(maxLength := 100, storeType := "nvarchar"),
                        .Texto_Sql = c.String(unicode := false),
                        .Id_Informe = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id_Consulta) _
                .ForeignKey("dbo.Informe", Function(t) t.Id_Informe, cascadeDelete := True) _
                .Index(Function(t) t.Id_Informe)
            
            CreateTable(
                "dbo.Informe",
                Function(c) New With
                    {
                        .Id_Informe = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(maxLength := 100, storeType := "nvarchar"),
                        .Usuario = c.String(maxLength := 50, storeType := "nvarchar"),
                        .Hora = c.String(maxLength := 10, storeType := "nvarchar"),
                        .Lunes = c.Boolean(nullable := False),
                        .Martes = c.Boolean(nullable := False),
                        .Miercoles = c.Boolean(nullable := False),
                        .Jueves = c.Boolean(nullable := False),
                        .Viernes = c.Boolean(nullable := False),
                        .Sabado = c.Boolean(nullable := False),
                        .Domingo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id_Informe)
            
            CreateTable(
                "dbo.Parametro",
                Function(c) New With
                    {
                        .Id_Parametro = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(maxLength := 25, storeType := "nvarchar"),
                        .Valor = c.String(unicode := false),
                        .Id_Consulta = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id_Parametro) _
                .ForeignKey("dbo.Consulta", Function(t) t.Id_Consulta, cascadeDelete := True) _
                .Index(Function(t) t.Id_Consulta)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Parametro", "Id_Consulta", "dbo.Consulta")
            DropForeignKey("dbo.Consulta", "Id_Informe", "dbo.Informe")
            DropIndex("dbo.Parametro", New String() { "Id_Consulta" })
            DropIndex("dbo.Consulta", New String() { "Id_Informe" })
            DropTable("dbo.Parametro")
            DropTable("dbo.Informe")
            DropTable("dbo.Consulta")
        End Sub
    End Class
End Namespace
