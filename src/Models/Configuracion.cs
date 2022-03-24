using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Configuracion 
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        [StringLength(20)]
        public string Codigo  { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        [Display(Name = "Area Configuración")]
        [StringLength(50)]
        public string Modulo  { get; set; }

        [Required]
        [Display(Name = "Valor 1")]
        [StringLength(100)]
        public string Valor { get; set; }

        [Display(Name = "Valor 2")]
        [StringLength(100)]
        public string Valor2  { get; set; }

        [Required]
        [Display(Name = "Valido Desde Fecha")]
        [DataType(DataType.Date)]
        public DateTime DesdeFecha { get; set; }

        [Required]
        [Display(Name = "Valido Hasta La Fecha")]
        [DataType(DataType.Date)]
        public DateTime HastaFecha { get; set; }

        [Display(Name = "Esta Activo?")]
        public Boolean Activo  { get; set; }

    }
}
