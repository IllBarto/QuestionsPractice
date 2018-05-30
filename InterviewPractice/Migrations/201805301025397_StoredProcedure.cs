namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoredProcedure : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("CustomStoredProcedure", p => new { id = p.Int() }, "SELECT * FROM MarketsNames" +
                " WHERE id = @id" );
        }
        
        public override void Down()
        {
        }
    }
}
