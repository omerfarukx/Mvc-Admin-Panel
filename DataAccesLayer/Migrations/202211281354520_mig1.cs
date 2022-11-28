namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "WriterMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Admins", "AdminUserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "AdminUserName", c => c.String(maxLength: 50));
            DropColumn("dbo.Admins", "WriterMail");
        }
    }
}
