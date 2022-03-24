﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Anomalia      
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

    }
}
