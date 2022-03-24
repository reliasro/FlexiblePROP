using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class EquipoPropiedad 
    {
        public int ID { get; set; }

        [Display(Name = "Descripcion Breve")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        [Display(Name = "Marca")]
        [StringLength(100)]
        public string Marca { get; set; }

        [Display(Name = "Modelo ")]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Display(Name = "No. Serie ")]
        [StringLength(100)]
        public string Serie { get; set; }

        [Display(Name = "Valor Del Equipo")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor  { get; set; }

        [Display(Name = "Imagen del Equipo ")]
        [StringLength(200)]
        [DataType(DataType.ImageUrl)]
        public string NombreImagen { get; set; }


        [Required]
        [Display(Name ="Propiedad")]
        public int PropiedadID {get; set;}
        public Propiedad Propiedad { get; set; }
    }
}
