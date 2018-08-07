namespace ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Data_Into_ApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nick", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "Fname", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "Lname", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Lname");
            DropColumn("dbo.AspNetUsers", "Fname");
            DropColumn("dbo.AspNetUsers", "Nick");
        }
    }
}
