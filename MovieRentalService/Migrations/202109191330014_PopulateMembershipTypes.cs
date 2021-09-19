namespace MovieRentalService.Migrations
{
    using MovieRentalService.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipType (SignUpFee, DurationInMonths, DiscountRate) VALUES (0, 0, 0)");
            Sql("INSERT INTO MembershipType (SignUpFee, DurationInMonths, DiscountRate) VALUES (30, 1, 10)");
            Sql("INSERT INTO MembershipType (SignUpFee, DurationInMonths, DiscountRate) VALUES (90, 3, 15)");
            Sql("INSERT INTO MembershipType (SignUpFee, DurationInMonths, DiscountRate) VALUES (300, 12, 20)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM MembershipType WHERE Id = '1'");
            Sql("DELETE FROM MembershipType WHERE Id = '2'");
            Sql("DELETE FROM MembershipType WHERE Id = '3'");
            Sql("DELETE FROM MembershipType WHERE Id = '4'");
        }
    }
}
