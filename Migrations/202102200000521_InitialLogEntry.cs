namespace GlucoCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialLogEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.entry_log",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BSL = c.Int(nullable: false),
                        Carbs = c.Int(nullable: false),
                        InsulinDosed = c.Double(nullable: false, storeType: "real"),
                        EntryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.entry_log");
        }
    }
}
