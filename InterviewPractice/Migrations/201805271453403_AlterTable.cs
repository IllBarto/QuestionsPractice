namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarketsTable", "Product_Id", c => c.Int());
            CreateIndex("dbo.MarketsTable", "Product_Id");
            AddForeignKey("dbo.MarketsTable", "Product_Id", "dbo.ProductsTable", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MarketsTable", "Product_Id", "dbo.ProductsTable");
            DropIndex("dbo.MarketsTable", new[] { "Product_Id" });
            DropColumn("dbo.MarketsTable", "Product_Id");
        }
    }
}
