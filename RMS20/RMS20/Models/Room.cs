using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RMS20.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int Status { get; set; }//Available or Not
        public string Type { get; set; }//Single or Double room

    }
}
