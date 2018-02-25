namespace HostelManagementSystem.Data.Migrations
{
    using HostelManagementSystem.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HostelManagementSystem.Data.MealCalculationDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HostelManagementSystem.Data.MealCalculationDBContext context)
        {
            
        }
    }
}
