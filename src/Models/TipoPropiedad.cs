using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class TipoPropiedad 
    {
        public int ID { get; set; }
        public int GrupoPropiedadID  { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        public ICollection<Propiedad> Propiedades { get; set; }
        public GrupoPropiedad GrupoPropiedad  { get; set; }

    }
}
