namespace ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Shop_Item : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shop_Item",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Image_URL = c.String(maxLength: 600),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Genre = c.String(nullable: false, maxLength: 50),
                        Image_Name = c.String(),
                        Created = c.DateTime(nullable: false),
                        Added_By_UID = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shop_Item");
        }
    }
}
