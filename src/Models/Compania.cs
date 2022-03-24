using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Compania   
    {
        public int ID { get; set; }
        public int GrupoCompaniaID  { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        public GrupoCompania GrupoCompania { get; set; }
    }
}
