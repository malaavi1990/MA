namespace MA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "UserId");
        }
    }
}
