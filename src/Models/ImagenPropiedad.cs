using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class ImagenPropiedad
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nombre de la Imagen ")]
        [StringLength(200)]
        [DataType(DataType.ImageUrl)]
        public string NombreImagen { get; set; }

        public int PropiedadID {get; set;}
        public Propiedad Propiedad { get; set; }
    }
}
