namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipType SET NAME = 'Pay as You Go' where Id = 1");
            Sql("UPDATE MembershipType SET NAME = 'Monthly' where Id = 2");
            Sql("UPDATE MembershipType SET NAME = 'Quarterly' where Id = 3");
            Sql("UPDATE MembershipType SET NAME = 'Annual' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
