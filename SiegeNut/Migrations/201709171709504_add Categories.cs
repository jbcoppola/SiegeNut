namespace SiegeNut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Review", "Product", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Review", "Product");
        }
    }
}
