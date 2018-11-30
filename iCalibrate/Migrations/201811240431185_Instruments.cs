namespace iCalibrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Instruments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instruments",
                c => new
                    {
                        InstrumentId = c.Int(nullable: false, identity: true),
                        InstrumentMasterId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        IdentificationNo = c.String(),
                        Range = c.String(),
                        StandardInstUsed = c.String(),
                    })
                .PrimaryKey(t => t.InstrumentId)
                .ForeignKey("dbo.InstrumentMasters", t => t.InstrumentMasterId)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .Index(t => t.InstrumentMasterId)
                .Index(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instruments", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Instruments", "InstrumentMasterId", "dbo.InstrumentMasters");
            DropIndex("dbo.Instruments", new[] { "LocationId" });
            DropIndex("dbo.Instruments", new[] { "InstrumentMasterId" });
            DropTable("dbo.Instruments");
        }
    }
}
