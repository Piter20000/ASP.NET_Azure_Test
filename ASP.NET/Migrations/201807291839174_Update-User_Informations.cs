namespace ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser_Informations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User_Informations", "UID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User_Informations", "UID", c => c.String(nullable: false));
        }
    }
}
