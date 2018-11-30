using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalibrate.Models
{
    public class ReportHeaderConfig
    {
        [Key, Column(Order = 0)]
        public int InstrumentMasterId { get; set; }

        [ForeignKey("InstrumentMasterId")]
        public InstrumentMasters InstrumentMaster;

        [Key, Column(Order = 1)]
        public int FieldId { get; set; }

        public int FieldSerial { get; set; }

        [StringLength(50)]
        public string FieldName { get; set; }

        [StringLength(50)]
        public string FieldCaption { get; set; }

        [StringLength(1)]
        public string HeaderFooterFlag { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}
