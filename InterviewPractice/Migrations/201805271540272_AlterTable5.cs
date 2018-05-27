namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable5 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MarketsTable", newName: "MarketsNames");
            CreateTable(
                "dbo.MarketsLocProd",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        MarketLocation = c.String(name: "Market Location"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MarketsNames", t => t.Id)
                .Index(t => t.Id);
            
            DropColumn("dbo.MarketsNames", "Market Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MarketsNames", "Market Location", c => c.String());
            DropForeignKey("dbo.MarketsLocProd", "Id", "dbo.MarketsNames");
            DropIndex("dbo.MarketsLocProd", new[] { "Id" });
            DropTable("dbo.MarketsLocProd");
            RenameTable(name: "dbo.MarketsNames", newName: "MarketsTable");
        }
    }
}
