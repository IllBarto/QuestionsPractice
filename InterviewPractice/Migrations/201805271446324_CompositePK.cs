namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompositePK : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductsTable");
            AlterColumn("dbo.ProductsTable", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductsTable", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ProductsTable", new[] { "Id", "Name" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProductsTable");
            AlterColumn("dbo.ProductsTable", "Name", c => c.String());
            AlterColumn("dbo.ProductsTable", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ProductsTable", "Id");
        }
    }
}
