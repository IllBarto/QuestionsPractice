namespace InterviewPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationStoredP : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("SelectProductById", p => new { id = p.Int() }, "SELECT * FROM ProductsTable Where id = @id ");
        }
        
        public override void Down()
        {
        }
    }
}
