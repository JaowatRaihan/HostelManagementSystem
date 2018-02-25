namespace HostelManagementSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Monthlymealtotalclassadded22 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonthlyMealTotals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Bazar = c.Double(nullable: false),
                        RealCost = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        Status = c.String(),
                        StatusClearDate = c.DateTime(nullable: false),
                        Month = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MonthlyMealTotals");
        }
    }
}
