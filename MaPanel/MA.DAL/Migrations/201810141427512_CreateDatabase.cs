namespace MA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
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
            DropTable("dbo.Roles");
        }
    }
}
