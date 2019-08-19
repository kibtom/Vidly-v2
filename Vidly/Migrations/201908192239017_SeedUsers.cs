namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2a03e4f3-28f5-4b36-9bbe-e7617cd9aa81', N'admin@vidly.com', 0, N'ADPctFDWVk1NdCg4SVX0Ykb7BUrXgvLOlMJ0Ht3e2A2LUvoK2iskEwC0v1KTIeeBRg==', N'9c4f2e3a-b173-4274-9059-a4aa9c76b309', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6610a25c-ddff-4d1c-80b6-bfd2336ccec2', N'guest@vidly.com', 0, N'AJTWED+VjpwY/EpW10N7Y3ul+QMWRCN3VCoq9YFWuMfDuf0bNw5p85tePbWMkaRn8A==', N'a0efc488-4af3-48ee-b7c9-dbb0fe134d67', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dcd54b9f-31c9-4df7-96b3-ae3d79699181', N'admin2@vidly.com', 0, N'AHRJg+nE86lYvJkKFARDtabGj/qGm9HF6qQ5Au5xh46RxkRH5V1kaAmkITml74potA==', N'4e8fcedc-8226-451d-af62-7429ddae069f', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c43fb229-d59e-418f-956b-78d8d5dbd656', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2a03e4f3-28f5-4b36-9bbe-e7617cd9aa81', N'c43fb229-d59e-418f-956b-78d8d5dbd656')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dcd54b9f-31c9-4df7-96b3-ae3d79699181', N'c43fb229-d59e-418f-956b-78d8d5dbd656')



");
        }
        
        public override void Down()
        {
        }
    }
}
