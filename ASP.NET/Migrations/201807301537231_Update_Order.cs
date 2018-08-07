namespace ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Order : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "RazorPayID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "RazorPayID");
        }
    }
}
