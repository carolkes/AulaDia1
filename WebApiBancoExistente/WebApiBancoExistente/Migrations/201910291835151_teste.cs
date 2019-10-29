namespace WebApiBancoExistente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.Carroes", newName: "Carros");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Carros", newName: "Carroes");
        }
    }
}
