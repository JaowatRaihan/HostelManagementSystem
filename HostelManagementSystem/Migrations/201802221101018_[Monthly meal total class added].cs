namespace HostelManagementSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Monthlymealtotalclassadded : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Meals");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BazarAmount = c.Double(nullable: false),
                        MealCount = c.Int(nullable: false),
                        Month = c.String(),
                        Year = c.String(),
                        MemberID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
