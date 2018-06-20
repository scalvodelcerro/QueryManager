Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddTableEjecucion
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Ejecucion",
                Function(c) New With
                    {
                        .Id_Ejecucion = c.Int(nullable := False, identity := True),
                        .HoraProgramada = c.String(maxLength := 10, storeType := "nvarchar"),
                        .HoraEjecucion = c.DateTime(nullable := False, precision := 0),
                        .Resultado = c.String(unicode := false),
                        .RutaFichero = c.String(unicode := false),
                        .Id_Informe = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id_Ejecucion) _
                .ForeignKey("dbo.Informe", Function(t) t.Id_Informe, cascadeDelete := True) _
                .Index(Function(t) t.Id_Informe)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Ejecucion", "Id_Informe", "dbo.Informe")
            DropIndex("dbo.Ejecucion", New String() { "Id_Informe" })
            DropTable("dbo.Ejecucion")
        End Sub
    End Class
End Namespace
