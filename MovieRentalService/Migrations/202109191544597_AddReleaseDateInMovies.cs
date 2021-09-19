namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDateInMovies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movie", "Genre_Id", "dbo.Genre");
            DropIndex("dbo.Movie", new[] { "Genre_Id" });
            AddColumn("dbo.Movie", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movie", "Genre_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movie", "Genre_Id");
            AddForeignKey("dbo.Movie", "Genre_Id", "dbo.Genre", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movie", "Genre_Id", "dbo.Genre");
            DropIndex("dbo.Movie", new[] { "Genre_Id" });
            AlterColumn("dbo.Movie", "Genre_Id", c => c.Int());
            DropColumn("dbo.Movie", "ReleaseDate");
            CreateIndex("dbo.Movie", "Genre_Id");
            AddForeignKey("dbo.Movie", "Genre_Id", "dbo.Genre", "Id");
        }
    }
}
