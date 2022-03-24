using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Factura
    {
        public int ID { get; set; }
        public int? ClienteID  { get; set; }

        [Display(Name = "Codigo Factura")]
        [StringLength(50)]
        public string CodigoFactura  { get; set; }

        [Required]
        [Display(Name = "Villa Tratada")]
        [StringLength(50)]
        public string Villa { get; set; }

        [Required]
        [Display(Name = "Propietario Villa")]
        [StringLength(100)]
        public string PropietarioVilla { get; set; }

        [Display(Name = "Valor Factura")]
        [DataType(DataType.Currency)]
        public Decimal ValorFactura { get { return (LecturaFinal-LecturaInicial)*540; } }

        [Display(Name = "Concepto")]
        [StringLength(250)]
        public string Emisor { get; set; }

        [Display(Name = "Moneda")]
        [StringLength(50)]
        public string Moneda { get; set; }

        [Required]
        [Display(Name = "Fecha Facturacion")]
        [DataType(DataType.Date)]
        public DateTime FechaEmision { get; set; }

        [Required]
        [Display(Name = "Fecha Vencimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaVencimiento  { get; set; }

        [Display(Name ="Lectura Inicial")]
        [Range(0,999999)]
        public int LecturaInicial { get; set; }

        [Display(Name = "Lectura Final")]
        [Range(0,999999)]
        public int LecturaFinal { get; set; }

        [Display(Name = "Balance Actual")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        public Decimal BalanceActual { get; set; }

        [Display(Name = "Observaciones")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string Observaciones { get; set; }

        
        //public int PropiedadID  { get; set; }
        public Cliente Cliente  { get; set; }

    }
}