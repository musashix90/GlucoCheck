namespace GlucoCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserIdToLogEntry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.entry_log", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.entry_log", "UserId");
            AddForeignKey("dbo.entry_log", "UserId", "dbo.users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.entry_log", "UserId", "dbo.users");
            DropIndex("dbo.entry_log", new[] { "UserId" });
            DropColumn("dbo.entry_log", "UserId");
        }
    }
}
