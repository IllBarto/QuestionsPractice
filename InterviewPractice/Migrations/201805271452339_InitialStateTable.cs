namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialStateTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MarketsTable");
            DropPrimaryKey("dbo.ProductsTable");
            AlterColumn("dbo.MarketsTable", "Name", c => c.String());
            AlterColumn("dbo.MarketsTable", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ProductsTable", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ProductsTable", "Name", c => c.String());
            AddPrimaryKey("dbo.MarketsTable", "Id");
            AddPrimaryKey("dbo.ProductsTable", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProductsTable");
            DropPrimaryKey("dbo.MarketsTable");
            AlterColumn("dbo.ProductsTable", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProductsTable", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.MarketsTable", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.MarketsTable", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ProductsTable", new[] { "Id", "Name" });
            AddPrimaryKey("dbo.MarketsTable", "Name");
        }
    }
}
