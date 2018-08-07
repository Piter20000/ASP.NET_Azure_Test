namespace ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UID = c.String(),
                        Ordered = c.DateTime(nullable: false),
                        Paid = c.DateTime(nullable: false),
                        Delivered = c.DateTime(nullable: false),
                        UserInformationsID = c.Int(nullable: false),
                        ShopItemID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Shop_Item", t => t.ShopItemID, cascadeDelete: true)
                .ForeignKey("dbo.User_Informations", t => t.UserInformationsID, cascadeDelete: true)
                .Index(t => t.UserInformationsID)
                .Index(t => t.ShopItemID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserInformationsID", "dbo.User_Informations");
            DropForeignKey("dbo.Orders", "ShopItemID", "dbo.Shop_Item");
            DropIndex("dbo.Orders", new[] { "ShopItemID" });
            DropIndex("dbo.Orders", new[] { "UserInformationsID" });
            DropTable("dbo.Orders");
        }
    }
}
