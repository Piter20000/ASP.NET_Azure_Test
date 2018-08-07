namespace ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_User_Informations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User_Informations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UID = c.String(nullable: false),
                        Fname = c.String(nullable: false, maxLength: 255),
                        Lname = c.String(nullable: false, maxLength: 255),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Postal_Code = c.String(nullable: false, maxLength: 255),
                        City = c.String(nullable: false, maxLength: 255),
                        Street = c.String(nullable: false, maxLength: 255),
                        House_Number = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User_Informations");
        }
    }
}
