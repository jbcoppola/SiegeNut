namespace SiegeNut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatereviews : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "ID", "dbo.AspNetUsers");
            DropIndex("dbo.Reviews", new[] { "ID" });
            DropPrimaryKey("dbo.Reviews");
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Reviews", "ProductID", c => c.Int(nullable: false));
            AddColumn("dbo.Reviews", "AuthorID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Reviews", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Reviews", "ID");
            CreateIndex("dbo.Reviews", "ProductID");
            CreateIndex("dbo.Reviews", "AuthorID");
            AddForeignKey("dbo.Reviews", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "AuthorID", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Reviews", "Product");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Product", c => c.String());
            DropForeignKey("dbo.Reviews", "AuthorID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reviews", "ProductID", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "AuthorID" });
            DropIndex("dbo.Reviews", new[] { "ProductID" });
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Reviews", "ID", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Reviews", "AuthorID");
            DropColumn("dbo.Reviews", "ProductID");
            DropTable("dbo.Products");
            AddPrimaryKey("dbo.Reviews", "ID");
            CreateIndex("dbo.Reviews", "ID");
            AddForeignKey("dbo.Reviews", "ID", "dbo.AspNetUsers", "Id");
        }
    }
}
