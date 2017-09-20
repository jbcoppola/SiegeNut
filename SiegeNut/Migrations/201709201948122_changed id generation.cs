namespace SiegeNut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedidgeneration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Reviews", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Reviews", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Reviews", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Reviews", "ID");
        }
    }
}
