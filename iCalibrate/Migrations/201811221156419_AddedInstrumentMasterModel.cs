namespace iCalibrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInstrumentMasterModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InstrumentMasters",
                c => new
                    {
                        InstrumentMasterId = c.Int(nullable: false, identity: true),
                        InstrumentMasterName = c.String(maxLength: 50),
                        CertificateNo = c.String(),
                    })
                .PrimaryKey(t => t.InstrumentMasterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InstrumentMasters");
        }
    }
}
