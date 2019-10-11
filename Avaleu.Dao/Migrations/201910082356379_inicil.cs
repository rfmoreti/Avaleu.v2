namespace Avaleu.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicil : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avaliacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoProjeto = c.Int(nullable: false),
                        CodigoProfessor = c.Int(nullable: false),
                        Comentario = c.String(),
                        Situacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Professor_Id = c.Int(),
                        Projeto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Professor_Id)
                .ForeignKey("dbo.Projeto", t => t.Projeto_Id)
                .Index(t => t.Professor_Id)
                .Index(t => t.Projeto_Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Telefone = c.String(),
                        Professor = c.Boolean(nullable: false),
                        CodigoTime = c.Int(),
                        Ativo = c.Boolean(nullable: false),
                        Time_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Time", t => t.Time_Id)
                .Index(t => t.Time_Id);
            
            CreateTable(
                "dbo.Time",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projeto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        Descricao = c.String(),
                        CodigoTime = c.Int(nullable: false),
                        Arquivo = c.String(),
                        DataLimite = c.DateTime(nullable: false),
                        DataPostagem = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Time_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Time", t => t.Time_Id)
                .Index(t => t.Time_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projeto", "Time_Id", "dbo.Time");
            DropForeignKey("dbo.Avaliacao", "Projeto_Id", "dbo.Projeto");
            DropForeignKey("dbo.Usuario", "Time_Id", "dbo.Time");
            DropForeignKey("dbo.Avaliacao", "Professor_Id", "dbo.Usuario");
            DropIndex("dbo.Projeto", new[] { "Time_Id" });
            DropIndex("dbo.Usuario", new[] { "Time_Id" });
            DropIndex("dbo.Avaliacao", new[] { "Projeto_Id" });
            DropIndex("dbo.Avaliacao", new[] { "Professor_Id" });
            DropTable("dbo.Projeto");
            DropTable("dbo.Time");
            DropTable("dbo.Usuario");
            DropTable("dbo.Avaliacao");
        }
    }
}
