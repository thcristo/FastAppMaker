namespace AppMaker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NavigationMenusAndLinks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NavigationMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Caption = c.String(nullable: false, maxLength: 50),
                        RelativeOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NavigationLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Caption = c.String(nullable: false, maxLength: 50),
                        RelativeOrder = c.Int(nullable: false),
                        MenuId = c.Int(nullable: false),
                        RelativeUrl = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NavigationMenus", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NavigationLinks", "MenuId", "dbo.NavigationMenus");
            DropIndex("dbo.NavigationLinks", new[] { "MenuId" });
            DropTable("dbo.NavigationLinks");
            DropTable("dbo.NavigationMenus");
        }
    }
}
