using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalibrate.Models
{
    public class Locations
    {
        [Key]
        public int LocationId { get; set; }

        [StringLength(50)]
        public string LocationName { get; set; }
        public int LocationIndex { get; set; }
    }
}
