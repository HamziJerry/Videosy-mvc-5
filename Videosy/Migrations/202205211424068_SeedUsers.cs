namespace Videosy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9166b96b-9214-4a76-8d25-51fb68faf737', N'guest@videosy.com', 0, N'ADalEgo5oSvKdU5j73OGj4Tu41lh3tHMfrcPBdB/c5Ybf/cyQ+7E99IIACKXC1IGfg==', N'd1bd2214-7e6c-468b-b970-886293a6b960', NULL, 0, 0, NULL, 1, 0, N'guest@videosy.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e65052bf-e25a-4e9e-918c-c40006869563', N'admin@videosy.com', 0, N'ANkoJZ2zA/E4aoC2i/A5v0F0hCQwTWJ6mW5PutFVLrFhP6XrNlnB7ImXuuCaUtXzCg==', N'4c194114-a8fd-4cff-93dc-4ee7091a50df', NULL, 0, 0, NULL, 1, 0, N'admin@videosy.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0b005fef-4d03-4408-b1a7-990322001a3d', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e65052bf-e25a-4e9e-918c-c40006869563', N'0b005fef-4d03-4408-b1a7-990322001a3d')

");
        }
        
        public override void Down()
        {
        }
    }
}
