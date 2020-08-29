namespace BancoDadosOsorioA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableMontadora : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Montadoras",
                c => new
                    {
                        MontadoraId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cnpj = c.String(),
                    })
                .PrimaryKey(t => t.MontadoraId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Montadoras");
        }
    }
}
