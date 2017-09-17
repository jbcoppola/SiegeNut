namespace SiegeNut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Review", "Author", c => c.String());

        }
        
        public override void Down()
        {
            DropColumn("dbo.Review", "Author");
        }
    }
}
