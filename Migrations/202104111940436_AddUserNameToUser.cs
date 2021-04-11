namespace GlucoCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserNameToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "UserName", c => c.String(maxLength: 2147483647));
            CreateIndex("dbo.users", "UserName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.users", "UserName");
            DropColumn("dbo.users", "UserName");
        }
    }
}
