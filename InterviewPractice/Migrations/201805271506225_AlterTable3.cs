namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductMarkets", newName: "MarketProductTable");
            RenameColumn(table: "dbo.MarketProductTable", name: "Product_Id", newName: "ProductID");
            RenameColumn(table: "dbo.MarketProductTable", name: "Market_Id", newName: "MarketID");
            RenameIndex(table: "dbo.MarketProductTable", name: "IX_Market_Id", newName: "IX_MarketID");
            RenameIndex(table: "dbo.MarketProductTable", name: "IX_Product_Id", newName: "IX_ProductID");
            DropPrimaryKey("dbo.MarketProductTable");
            AddPrimaryKey("dbo.MarketProductTable", new[] { "MarketID", "ProductID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MarketProductTable");
            AddPrimaryKey("dbo.MarketProductTable", new[] { "Product_Id", "Market_Id" });
            RenameIndex(table: "dbo.MarketProductTable", name: "IX_ProductID", newName: "IX_Product_Id");
            RenameIndex(table: "dbo.MarketProductTable", name: "IX_MarketID", newName: "IX_Market_Id");
            RenameColumn(table: "dbo.MarketProductTable", name: "MarketID", newName: "Market_Id");
            RenameColumn(table: "dbo.MarketProductTable", name: "ProductID", newName: "Product_Id");
            RenameTable(name: "dbo.MarketProductTable", newName: "ProductMarkets");
        }
    }
}
