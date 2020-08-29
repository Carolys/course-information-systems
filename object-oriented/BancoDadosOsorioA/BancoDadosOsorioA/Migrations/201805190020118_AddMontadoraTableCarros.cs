namespace BancoDadosOsorioA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMontadoraTableCarros : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carros", "Montadora_MontadoraId", c => c.Int());
            CreateIndex("dbo.Carros", "Montadora_MontadoraId");
            AddForeignKey("dbo.Carros", "Montadora_MontadoraId", "dbo.Montadoras", "MontadoraId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carros", "Montadora_MontadoraId", "dbo.Montadoras");
            DropIndex("dbo.Carros", new[] { "Montadora_MontadoraId" });
            DropColumn("dbo.Carros", "Montadora_MontadoraId");
        }
    }
}
