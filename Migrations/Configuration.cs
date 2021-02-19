namespace GlucoCheck.Migrations
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;
    using GlucoCheck.Classes;

    internal sealed class Configuration : DbMigrationsConfiguration<GlucoCheck.Classes.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(AppDbContext context)
        {
            
        }
    }
}
