namespace MA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewsCategories",
                c => new
                    {
                        NewsCategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Icon = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NewsCategoryId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        Description = c.String(),
                        Text = c.String(),
                        WriterName = c.String(),
                        Visit = c.Int(nullable: false),
                        Thumbnail = c.String(),
                        Image = c.String(),
                        WriterImage = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NewsId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Icon = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        Description = c.String(),
                        Text = c.String(),
                        Image = c.String(),
                        Thumbnail = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Visit = c.Int(nullable: false),
                        Price = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        Description = c.String(),
                        Text = c.String(),
                        Icon = c.String(),
                        Image = c.String(),
                        Thumbnail = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.SiteSections",
                c => new
                    {
                        SiteSectionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.SiteSectionId);
            
            CreateTable(
                "dbo.SiteSettings",
                c => new
                    {
                        SiteSettingId = c.Int(nullable: false, identity: true),
                        SiteTitle = c.String(),
                        Icon = c.String(),
                        CopyRight = c.String(),
                        Description = c.String(),
                        KeyWord = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        WorkTime = c.String(),
                        SupportEmail = c.String(),
                        InfoEmail = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.SiteSettingId);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        Thumbnail = c.String(),
                        Sort = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.SliderId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Post = c.String(),
                        Summary = c.String(),
                        Thumbnail = c.String(),
                        Image = c.String(),
                        MobileNumber = c.String(),
                        Email = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleId = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserRoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        MobileNumber = c.String(),
                        ActiveCode = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        ImageName = c.String(),
                        NationalCode = c.String(),
                        FistName = c.String(),
                        LastName = c.String(),
                        Country = c.String(),
                        State = c.String(),
                        City = c.String(),
                        Address = c.String(),
                        PostalCode = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Teams");
            DropTable("dbo.Sliders");
            DropTable("dbo.SiteSettings");
            DropTable("dbo.SiteSections");
            DropTable("dbo.Services");
            DropTable("dbo.Roles");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.News");
            DropTable("dbo.NewsCategories");
        }
    }
}
