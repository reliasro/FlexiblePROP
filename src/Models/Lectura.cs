using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Lectura   
    {
        public int ID { get; set; }
        public int MedidorID { get; set; }
        public int LectorID { get; set; }
        public int RutaID { get; set; }
        public int? FacturaID { get; set; }
        public int? AnomaliaID { get; set; }
        public int PropiedaID  { get; set; }

        [Required]
        [Display(Name = "Marca")]
        [StringLength(100)]
        public string Marca { get; set; }

        [Required]
        [Display(Name = "Modelo ")]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "No. Serie ")]
        [StringLength(100)]
        public string Serie { get; set; }

        [Required]
        [Display(Name = "Fecha Programada Lectura")]
        [DataType(DataType.Date)]
        public DateTime FechaProgramada  { get; set; }

        [Required]
        [Display(Name = "Fecha Real Lectura")]
        [DataType(DataType.DateTime)]
        public DateTime FechaReal  { get; set; }

        [Required]
        [Display(Name = "Orden Lectura ")]
        [Range(0, 200)]
        public int OrdenLectura  { get; set; }

        [Required]
        [Display(Name = "Lectura Anterior")]
        [Range(0, 999999)]
        public int LecturaAnterior  { get; set; }

        [Required]
        [Display(Name = "Lectura Tomada")]
        [Range(0, 999999)]
        public int LecturaTomada  { get; set; }

        [Required]
        [Display(Name = "Consumo Facturado")]
        [Range(0, 999999)]
        public int ConsumoFacturado  { get; set; }

        [Display(Name = "Notas importantes ")]
        [StringLength(200)]
        public string Notas { get; set; }

        [Display(Name = "Esta Facturado")]
        public Boolean EstaFacturado  { get; set; }

        [Display(Name = "Latitud")]
        [StringLength(50)]
        public string Latitud { get; set; }

        [Display(Name = "Longitud")]
        [StringLength(50)]
        public string Longitud { get; set; }

        public Propiedad Propiedad { get; set; }
        public Medidor Medidor { get; set; }
        public Lector Lector  { get; set; }
        public Ruta Ruta  { get; set; }
        public Factura Factura { get; set; }
        public Anomalia Anomalia { get; set; }

    }
}
