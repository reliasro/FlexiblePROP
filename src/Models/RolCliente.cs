using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class RolCliente   
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        [StringLength(10)]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

     }
}
