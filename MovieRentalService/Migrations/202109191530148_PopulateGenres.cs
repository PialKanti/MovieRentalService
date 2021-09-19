namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genre (Name) VALUES ('Action')");
            Sql("INSERT INTO Genre (Name) VALUES ('Family')");
            Sql("INSERT INTO Genre (Name) VALUES ('Romance')");
            Sql("INSERT INTO Genre (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genre (Name) VALUES ('Science fiction')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genre WHERE Id = '1'");
            Sql("DELETE FROM Genre WHERE Id = '2'");
            Sql("DELETE FROM Genre WHERE Id = '3'");
            Sql("DELETE FROM Genre WHERE Id = '4'");
            Sql("DELETE FROM Genre WHERE Id = '5'");
        }
    }
}
