using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalibrate.Models
{
    public class FieldTypes
    {
        [Key]
        [StringLength(1)]
        public string FieldType { get; set; }

        [StringLength(20)]
        public string FieldTypeName { get; set; }

        [StringLength(20)]
        public string AssociatedDataType { get; set; }
    }
}
