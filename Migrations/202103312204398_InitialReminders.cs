namespace GlucoCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialReminders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.reminders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TaskToRemind = c.String(nullable: false, maxLength: 2147483647),
                        TimeToRemind = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.reminders");
        }
    }
}
