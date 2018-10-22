namespace MA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Users", "FistName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Users", "FistName", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 5));
        }
    }
}
