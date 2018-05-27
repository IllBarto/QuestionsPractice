namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePK : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MarketsTable");
            AlterColumn("dbo.MarketsTable", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.MarketsTable", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.MarketsTable", "Name");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MarketsTable");
            AlterColumn("dbo.MarketsTable", "Name", c => c.String());
            AlterColumn("dbo.MarketsTable", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MarketsTable", "Id");
        }
    }
}
