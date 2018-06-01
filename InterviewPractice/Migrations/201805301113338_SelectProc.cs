namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SelectProc : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("SelectProduct", p => new { id = p.Int() }, "SELECT Name FROM ProductsTable Where id = @id ");

        }

        public override void Down()
        {
        }
    }
}
