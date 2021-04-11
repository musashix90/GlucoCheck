namespace GlucoCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserIdToReminder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.reminders", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.reminders", "UserId");
            AddForeignKey("dbo.reminders", "UserId", "dbo.users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.reminders", "UserId", "dbo.users");
            DropIndex("dbo.reminders", new[] { "UserId" });
            DropColumn("dbo.reminders", "UserId");
        }
    }
}
