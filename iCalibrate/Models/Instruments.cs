using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalibrate.Models
{
    public class Instruments
    {
        [Key]
        public int InstrumentId { get; set; }
        public string InstrumentName { get; set; }

        public int InstrumentMasterId { get; set; }
        [ForeignKey("InstrumentMasterId")]
        public InstrumentMasters InstrumentMaster { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Locations Location { get; set; }

        public string IdentificationNo { get; set; }
        public string Range { get; set; }


    }
}
