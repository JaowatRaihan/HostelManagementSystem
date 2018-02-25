using HostelManagementSystem.Entity;
using System.Data.Entity;

namespace HostelManagementSystem.Data
{
    public class MealCalculationDBContext : DbContext
    {
        public MealCalculationDBContext() : base("BaseContext")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<MonthlyMealTotal> MonthlyMealTotal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
