using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalibrate.Models
{
    public class InstrumentMasters
    {
        [Key]
        public int InstrumentMasterId { get; set; }

        [StringLength(255)]
        public string InstrumentMasterName { get; set; }
        [StringLength(255)]
        public string CertificateNo { get; set; }

    }
}
