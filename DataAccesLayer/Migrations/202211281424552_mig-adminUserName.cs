namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migadminUserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminUserName", c => c.String(maxLength: 50));
            DropColumn("dbo.Admins", "WriterMail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "WriterMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Admins", "AdminUserName");
        }
    }
}
