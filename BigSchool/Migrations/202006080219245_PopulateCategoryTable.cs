namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(id, NAME) values(1, 'Development')");
            Sql("INSERT INTO CATEGORIES(id, NAME) values(2, 'Business')");
            Sql("INSERT INTO CATEGORIES(id, NAME) values(3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
