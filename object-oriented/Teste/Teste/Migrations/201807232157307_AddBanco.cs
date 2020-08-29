namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlunosTurma",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Aluno_Id = c.Int(),
                        Turma_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Aluno_Id)
                .ForeignKey("dbo.Turmas", t => t.Turma_Id)
                .Index(t => t.Aluno_Id)
                .Index(t => t.Turma_Id);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Matricula = c.String(),
                        Telefone = c.String(),
                        Disciplina = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataCadastro = c.DateTime(nullable: false),
                        Professor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Professor_Id)
                .Index(t => t.Professor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turmas", "Professor_Id", "dbo.Pessoas");
            DropForeignKey("dbo.AlunosTurma", "Turma_Id", "dbo.Turmas");
            DropForeignKey("dbo.AlunosTurma", "Aluno_Id", "dbo.Pessoas");
            DropIndex("dbo.Turmas", new[] { "Professor_Id" });
            DropIndex("dbo.AlunosTurma", new[] { "Turma_Id" });
            DropIndex("dbo.AlunosTurma", new[] { "Aluno_Id" });
            DropTable("dbo.Turmas");
            DropTable("dbo.Pessoas");
            DropTable("dbo.AlunosTurma");
        }
    }
}
