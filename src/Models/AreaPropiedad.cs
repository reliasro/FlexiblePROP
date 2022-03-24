using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class AreaPropiedad  
    {
        public int ID { get; set; }

        [Display(Name = "Seleccione La Unidad")]
        public int UnidadID  { get; set; }

        [Display(Name = "Propiedad")]
        public int PropiedadID  { get; set; }

        [Display(Name = "Unidad Espacio ")]
        public Unidad UnidadEspacio { get; set; }
        public Propiedad Propiedad { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        [Required]
        [Display(Name = "Cantidad Espacio")]
        [Range(1,99)]
        public int CantidadEspacio  { get; set; }

    }
}
