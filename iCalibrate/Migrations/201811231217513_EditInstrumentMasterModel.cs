namespace iCalibrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditInstrumentMasterModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InstrumentMasters", "InstrumentMasterName", c => c.String(maxLength: 255));
            AlterColumn("dbo.InstrumentMasters", "CertificateNo", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InstrumentMasters", "CertificateNo", c => c.String());
            AlterColumn("dbo.InstrumentMasters", "InstrumentMasterName", c => c.String(maxLength: 50));
        }
    }
}
