namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreIdToMovies : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movie", name: "Genre_Id", newName: "GenreId");
            RenameIndex(table: "dbo.Movie", name: "IX_Genre_Id", newName: "IX_GenreId");
            AlterColumn("dbo.Movie", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movie", "Name", c => c.String());
            RenameIndex(table: "dbo.Movie", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Movie", name: "GenreId", newName: "Genre_Id");
        }
    }
}
