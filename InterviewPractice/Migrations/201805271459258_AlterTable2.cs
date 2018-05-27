namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MarketsTable", "Product_Id", "dbo.ProductsTable");
            DropIndex("dbo.MarketsTable", new[] { "Product_Id" });
            CreateTable(
                "dbo.ProductMarkets",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Market_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Market_Id })
                .ForeignKey("dbo.ProductsTable", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.MarketsTable", t => t.Market_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Market_Id);
            
            DropColumn("dbo.MarketsTable", "Product_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MarketsTable", "Product_Id", c => c.Int());
            DropForeignKey("dbo.ProductMarkets", "Market_Id", "dbo.MarketsTable");
            DropForeignKey("dbo.ProductMarkets", "Product_Id", "dbo.ProductsTable");
            DropIndex("dbo.ProductMarkets", new[] { "Market_Id" });
            DropIndex("dbo.ProductMarkets", new[] { "Product_Id" });
            DropTable("dbo.ProductMarkets");
            CreateIndex("dbo.MarketsTable", "Product_Id");
            AddForeignKey("dbo.MarketsTable", "Product_Id", "dbo.ProductsTable", "Id");
        }
    }
}
