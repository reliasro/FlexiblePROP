using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Ruta  
    {
        public int ID { get; set; }
        public int TipoRutaID  { get; set; }

        [Required]
        [Display(Name = "Codigo Ruta")]
        [StringLength(10)]
        public string Codigo  { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        [Required]
        [Display(Name = "Dia Lectura")]
        [Range(1,31)]
        public int DiaLectura    { get; set; }

        public TipoRuta TipoRuta  { get; set; }

    }
}
