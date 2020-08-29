namespace BancoDadosOsorioA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        IdPessoa = c.Int(nullable: false, identity: true),
                        Modelo = c.String(),
                        Ano = c.Int(nullable: false),
                        Cor = c.String(),
                        DataFabricacao = c.DateTime(nullable: false),
                        Peso = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdPessoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carros");
        }
    }
}
