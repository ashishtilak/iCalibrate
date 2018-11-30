namespace iCalibrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFieldNameInInstruments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instruments", "InstrumentName", c => c.String());
            DropColumn("dbo.Instruments", "StandardInstUsed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instruments", "StandardInstUsed", c => c.String());
            DropColumn("dbo.Instruments", "InstrumentName");
        }
    }
}
