namespace MA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "MobileNumber", c => c.String(maxLength: 15));
            AlterColumn("dbo.Users", "ImageName", c => c.String(maxLength: 250));
            AlterColumn("dbo.Users", "NationalCode", c => c.String(maxLength: 11));
            AlterColumn("dbo.Users", "Country", c => c.String(maxLength: 35));
            AlterColumn("dbo.Users", "State", c => c.String(maxLength: 35));
            AlterColumn("dbo.Users", "City", c => c.String(maxLength: 35));
            AlterColumn("dbo.Users", "Address", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "PostalCode", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "PostalCode", c => c.String());
            AlterColumn("dbo.Users", "Address", c => c.String());
            AlterColumn("dbo.Users", "City", c => c.String());
            AlterColumn("dbo.Users", "State", c => c.String());
            AlterColumn("dbo.Users", "Country", c => c.String());
            AlterColumn("dbo.Users", "NationalCode", c => c.String());
            AlterColumn("dbo.Users", "ImageName", c => c.String());
            AlterColumn("dbo.Users", "MobileNumber", c => c.String());
        }
    }
}
