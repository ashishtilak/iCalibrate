namespace iCalibrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FieldTypes",
                c => new
                    {
                        FieldType = c.String(nullable: false, maxLength: 1),
                        FieldTypeName = c.String(maxLength: 20),
                        AssociatedDataType = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.FieldType);
            
            CreateIndex("dbo.ReportDetailsConfigs", "FieldType");
            AddForeignKey("dbo.ReportDetailsConfigs", "FieldType", "dbo.FieldTypes", "FieldType");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReportDetailsConfigs", "FieldType", "dbo.FieldTypes");
            DropIndex("dbo.ReportDetailsConfigs", new[] { "FieldType" });
            DropTable("dbo.FieldTypes");
        }
    }
}
