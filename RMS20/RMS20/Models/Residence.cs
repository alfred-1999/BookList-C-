using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RMS20.Models
{
    public class Residence
    {
        [Key]
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public string Res_Gender { get; set; }
        public string Campus { get; set; }
    }
}
