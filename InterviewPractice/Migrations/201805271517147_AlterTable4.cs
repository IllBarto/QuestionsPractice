namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.MarketsTable", name: "Location", newName: "Market Location");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.MarketsTable", name: "Market Location", newName: "Location");
        }
    }
}
