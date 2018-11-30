namespace iCalibrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Locations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(maxLength: 50),
                        LocationIndex = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locations");
        }
    }
}
