namespace CineGest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class salas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salas", "Lugares", c => c.String());
        }
        
        public override void Down()
        {
        }
    }
}
