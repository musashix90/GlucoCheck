namespace GlucoCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 2147483647),
                        LastName = c.String(maxLength: 2147483647),
                        Password = c.String(maxLength: 2147483647),
                        SecurityQuestion = c.String(maxLength: 2147483647),
                        SecurityAnswer = c.String(maxLength: 2147483647),
                        DoctorName = c.String(maxLength: 2147483647),
                        Gender = c.String(maxLength: 2147483647),
                        BirthDate = c.DateTime(nullable: false),
                        Weight = c.Double(nullable: false, storeType: "real"),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
