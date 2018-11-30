namespace iCalibrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReportHeaderDetailsConfig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReportDetailsConfigs",
                c => new
                    {
                        InstrumentMasterId = c.Int(nullable: false),
                        FieldId = c.Int(nullable: false),
                        FieldSerial = c.Int(nullable: false),
                        FieldName = c.String(maxLength: 50),
                        FieldCaption = c.String(maxLength: 50),
                        FieldType = c.String(maxLength: 1),
                        DecimalPlaces = c.Int(nullable: false),
                        Formula = c.String(maxLength: 255),
                        DisplayFlag = c.Boolean(nullable: false),
                        UserId = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.InstrumentMasterId, t.FieldId });
            
            CreateTable(
                "dbo.ReportHeaderConfigs",
                c => new
                    {
                        InstrumentMasterId = c.Int(nullable: false),
                        FieldId = c.Int(nullable: false),
                        FieldSerial = c.Int(nullable: false),
                        FieldName = c.String(maxLength: 50),
                        FieldCaption = c.String(maxLength: 50),
                        HeaderFooterFlag = c.String(maxLength: 1),
                        UserId = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.InstrumentMasterId, t.FieldId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReportHeaderConfigs");
            DropTable("dbo.ReportDetailsConfigs");
        }
    }
}
