namespace MA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Users", "ActiveCode", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FistName", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 3));
            DropColumn("dbo.Users", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "FistName", c => c.String());
            AlterColumn("dbo.Users", "ActiveCode", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
        }
    }
}
