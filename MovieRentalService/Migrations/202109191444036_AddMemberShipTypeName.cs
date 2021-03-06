namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipType", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipType", "Name");
        }
    }
}
