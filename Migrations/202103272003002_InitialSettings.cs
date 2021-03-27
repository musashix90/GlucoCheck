namespace GlucoCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSettings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.settings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        HighBSLThreshold = c.Double(nullable: false),
                        LowBSLThreshold = c.Double(nullable: false),
                        MaxDailyReminder = c.Int(nullable: false),
                        SecondEntryReminder = c.Double(nullable: false),
                        IsMillimoles = c.Boolean(nullable: false),
                        ActiveStart = c.DateTime(),
                        ActiveEnd = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.settings", "UserId", "dbo.users");
            DropIndex("dbo.settings", new[] { "UserId" });
            DropTable("dbo.settings");
        }
    }
}
