namespace MovieRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Double(nullable: false),
                        DurationInMonths = c.Int(nullable: false),
                        DiscountRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customer", "MembershipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customer", "MembershipTypeId");
            AddForeignKey("dbo.Customer", "MembershipTypeId", "dbo.MembershipType", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "MembershipTypeId", "dbo.MembershipType");
            DropIndex("dbo.Customer", new[] { "MembershipTypeId" });
            DropColumn("dbo.Customer", "MembershipTypeId");
            DropTable("dbo.MembershipType");
        }
    }
}
