namespace ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Users : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5bb89257-005a-4d3d-b780-f16f2c8ee535', N'murdzia.piotr2012@gmail.com', 0, N'ABcV+ghUJaojHGx/XJc5XOq4GSwK3T8xnr6cGVVsgK9pa4bLCy9u6cF4UtyJJD813w==', N'14a4f13a-a602-42cb-ab7e-8152ee84857a', NULL, 0, 0, NULL, 1, 0, N'murdzia.piotr2012@gmail.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5e1ccb43-2338-4cc9-996d-0c4c6205a732', N'piterek20000@gmail.com', 0, N'ANBshX1OayN3s12Gj1vV4U+PVPXMyZ+b9LG+hic+ptvppJmRGLQ865Xb6rskY/Qksg==', N'79094cb9-b049-4bdd-a0ce-6ed496ac519f', NULL, 0, 0, NULL, 1, 0, N'piterek20000@gmail.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'86510cbe-42e7-4674-a026-c6c99f84c542', N'piter20000@gmail.com', 0, N'AAJuJlCQgNnRxl56DZuOZNeHcMxmdoJxJVfGmIjCedtZFMJt0Rk4wfyqEFA8Q688VQ==', N'6626bafe-866b-476b-ba9d-c81973440e22', NULL, 0, 0, NULL, 1, 0, N'piter20000@gmail.com')
                    
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c7b12e7a-dc6c-450b-b23f-93188917f372', N'CanManageShopItems')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5bb89257-005a-4d3d-b780-f16f2c8ee535', N'c7b12e7a-dc6c-450b-b23f-93188917f372')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5e1ccb43-2338-4cc9-996d-0c4c6205a732', N'c7b12e7a-dc6c-450b-b23f-93188917f372')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'86510cbe-42e7-4674-a026-c6c99f84c542', N'c7b12e7a-dc6c-450b-b23f-93188917f372')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
