﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RMS20.Models
{
    public class ResAdmin
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
    }
}
