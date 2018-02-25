namespace HostelManagementSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class TableChnaged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MonthlyMealTotals", "Year", c => c.String());
            AlterColumn("dbo.MonthlyMealTotals", "StatusClearDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MonthlyMealTotals", "StatusClearDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.MonthlyMealTotals", "Year");
        }
    }
}
