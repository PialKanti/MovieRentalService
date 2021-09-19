namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateAddedToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "DateAdded");
        }
    }
}
