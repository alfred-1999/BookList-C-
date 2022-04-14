using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RMS20.Models
{
    public class InspectionDetails
    {
        [Key]
        public int Id { get; set; }
        public int InspectedDate { get; set; }
        public string Comment { get; set; }
        public string ConditionStatus { get; set; }
    }
}
