namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToNewsletterToCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "IsSubscribedToNewsletter");
        }
    }
}
