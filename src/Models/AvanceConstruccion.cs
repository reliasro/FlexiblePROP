using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class AvanceConstruccion   
    {
        public int ID { get; set; }

        [Display(Name = "Propiedad")]
        public int PropiedadID { get; set; }

        [Display(Name = "Propiedad")]
        public Propiedad Propiedad { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime Fecha  { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        [Required]
        [Display(Name = "Porcentaje Avance (1%=0.01)")]
        [DisplayFormat(DataFormatString = "{0:P}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PorcentajeAvance  { get; set; }

    }
}
