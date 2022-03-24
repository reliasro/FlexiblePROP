using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class TipoMedidor  
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        public ICollection<Medidor> Medidores  { get; set; }

    }
}
