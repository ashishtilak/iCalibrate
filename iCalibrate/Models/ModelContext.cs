using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalibrate.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("DefaultConnection") { }


        public DbSet<Locations> Locations { get; set; }
        public DbSet<InstrumentMasters> InstrumentMasters { get; set; }
        public DbSet<Instruments> Instruments { get; set; }
        public DbSet<ReportHeaderConfig> ReportHeaderConfigs { get; set; }
        public DbSet<ReportDetailsConfig> ReportDetailsConfigs { get; set; }
        public DbSet<FieldTypes> FieldTypes { get; set; }

        // Override cascade delete convention
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
