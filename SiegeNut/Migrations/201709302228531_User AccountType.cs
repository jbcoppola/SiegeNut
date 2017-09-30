namespace SiegeNut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAccountType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AccountType", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AccountType");
        }
    }
}
