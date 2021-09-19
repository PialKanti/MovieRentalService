namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberInStockToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "NumberInStock");
        }
    }
}
