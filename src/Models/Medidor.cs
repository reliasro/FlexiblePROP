using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Medidor  
    {
        public int ID { get; set; }
        public int TipoMedidorID  { get; set; }
        public int PropiedadID  { get; set; }

        [Required]
        [Display(Name = "Marca")]
        [StringLength(100)]
        public string Marca  { get; set; }

        [Required]
        [Display(Name = "Modelo ")]
        [StringLength(50)]
        public string Modelo  { get; set; }

        [Required]
        [Display(Name = "No. Serie ")]
        [StringLength(100)]
        public string Serie  { get; set; }

        [Display(Name = "Precio Compra")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio  { get; set; }

        [Required]
        [Display(Name = "Fecha Instalacion")]
        [DataType(DataType.Date)]
        public DateTime FechaInstalacion  { get; set; }

        [Required]
        [Display(Name = "Lectura Instalacion")]
        [Range(0,999999)]
        public int LecturaInstalacion { get; set; }

        [Required]
        [Display(Name = "Ultima Lectura")]
        [Range(0, 999999)]
        public int UltimaLectura  { get; set; }

        [Display(Name = "Notas importantes ")]
        [StringLength(200)]
        public string Notas { get; set; }

        public TipoMedidor TipoMedidor { get; set; }
        public Propiedad Propiedad  { get; set; }
    }
}
