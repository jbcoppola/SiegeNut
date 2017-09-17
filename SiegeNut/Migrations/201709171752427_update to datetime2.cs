namespace SiegeNut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetodatetime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Review", "DateWritten", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Review", "DateWritten", c => c.DateTime(nullable: false));
        }
    }
}
