namespace MA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 15));
            DropColumn("dbo.Users", "FistName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "FistName", c => c.String(nullable: false, maxLength: 15));
            DropColumn("dbo.Users", "FirstName");
        }
    }
}
