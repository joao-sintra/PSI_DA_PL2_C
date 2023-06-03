namespace CineGest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cenas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filmes", "CategoriaID_Id", c => c.Int());
            AlterColumn("dbo.Filmes", "Duracao", c => c.Int(nullable: false));
            CreateIndex("dbo.Filmes", "CategoriaID_Id");
            AddForeignKey("dbo.Filmes", "CategoriaID_Id", "dbo.Categorias", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filmes", "CategoriaID_Id", "dbo.Categorias");
            DropIndex("dbo.Filmes", new[] { "CategoriaID_Id" });
            AlterColumn("dbo.Filmes", "Duracao", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Filmes", "CategoriaID_Id");
        }
    }
}
