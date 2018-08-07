namespace ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_Shop_Item : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    SET IDENTITY_INSERT [dbo].[Shop_Item] ON
                    INSERT INTO [dbo].[Shop_Item] ([ID], [Name], [Image_URL], [Price], [Genre], [Image_Name], [Created], [Added_By_UID]) VALUES (1, N'Intel Core i7-8700K Coffee Lake 6-Core 3.7 GHz', N'https://php-solution.000webhostapp.com/img/corei7.jpg', CAST(489.00 AS Decimal(18, 2)), N'Computer', N'corei7', N'2018-07-28 14:40:42', N'5bb89257-005a-4d3d-b780-f16f2c8ee535')
                    INSERT INTO [dbo].[Shop_Item] ([ID], [Name], [Image_URL], [Price], [Genre], [Image_Name], [Created], [Added_By_UID]) VALUES (2, N'Corsair Gaming Mouse SCIMITAR PRO RGB', N'https://php-solution.000webhostapp.com/img/Corsair-Gaming-SCIMITAR-PRO-RGB.jpg', CAST(79.00 AS Decimal(18, 2)), N'Computer', N'Corsair Gaming Mouse ', N'2018-07-28 14:41:31', N'5bb89257-005a-4d3d-b780-f16f2c8ee535')
                    INSERT INTO [dbo].[Shop_Item] ([ID], [Name], [Image_URL], [Price], [Genre], [Image_Name], [Created], [Added_By_UID]) VALUES (3, N'Corsair Crystal 570X RGB ATX Mid Tower Case', N'https://php-solution.000webhostapp.com/img/corsair570xrgb.jpg', CAST(189.00 AS Decimal(18, 2)), N'Computer', N'Tower Case', N'2018-07-28 14:42:08', N'5bb89257-005a-4d3d-b780-f16f2c8ee535')
                    INSERT INTO [dbo].[Shop_Item] ([ID], [Name], [Image_URL], [Price], [Genre], [Image_Name], [Created], [Added_By_UID]) VALUES (4, N'G.SKILL TridentZ RGB Series 32GB DDR4', N'https://php-solution.000webhostapp.com/img/gskill-tridentz-rgb.jpg', CAST(439.00 AS Decimal(18, 2)), N'Computer', N'G.SKILL TridentZ', N'2018-07-28 14:42:51', N'5bb89257-005a-4d3d-b780-f16f2c8ee535')
                    INSERT INTO [dbo].[Shop_Item] ([ID], [Name], [Image_URL], [Price], [Genre], [Image_Name], [Created], [Added_By_UID]) VALUES (5, N'NZXT H700i Mid Tower Chassis Tempered Case', N'https://php-solution.000webhostapp.com/img/nzxth700i.jpg', CAST(199.00 AS Decimal(18, 2)), N'Computer', N' Tower Chassis Tempered Case', N'2018-07-28 14:43:28', N'5bb89257-005a-4d3d-b780-f16f2c8ee535')
                    INSERT INTO [dbo].[Shop_Item] ([ID], [Name], [Image_URL], [Price], [Genre], [Image_Name], [Created], [Added_By_UID]) VALUES (6, N'Razer Blackwidow Gaming Mechanical Keyboard', N'https://php-solution.000webhostapp.com/img/razer-blackwidow.jpg', CAST(109.00 AS Decimal(18, 2)), N'Computer', N'Mechanical Keyboard', N'2018-07-28 14:44:05', N'5bb89257-005a-4d3d-b780-f16f2c8ee535')
                    INSERT INTO [dbo].[Shop_Item] ([ID], [Name], [Image_URL], [Price], [Genre], [Image_Name], [Created], [Added_By_UID]) VALUES (7, N'AMD RYZEN 7 1700 8-Core 3.0 GHz Socket AM4 CPU', N'https://php-solution.000webhostapp.com/img/ryzen7.jpg', CAST(299.00 AS Decimal(18, 2)), N'Computer', N'AMD RYZEN 7 1700', N'2018-07-28 14:44:49', N'5bb89257-005a-4d3d-b780-f16f2c8ee535')
                    INSERT INTO [dbo].[Shop_Item] ([ID], [Name], [Image_URL], [Price], [Genre], [Image_Name], [Created], [Added_By_UID]) VALUES (8, N'Samsung 850EVO BULK Solid State Drive', N'https://php-solution.000webhostapp.com/img/samsung-850evo.jpg', CAST(108.00 AS Decimal(18, 2)), N'Computer', N'Samsung 850EVO', N'2018-07-28 14:45:27', N'5bb89257-005a-4d3d-b780-f16f2c8ee535')
                    SET IDENTITY_INSERT [dbo].[Shop_Item] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}
