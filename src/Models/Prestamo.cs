using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Prestamo
    {
        public int ID { get; set; }
        public int ClienteID  { get; set; }

        [Display(Name = "Codigo Prestamo")]
        [StringLength(50,ErrorMessage ="Longitud no mayor a 50")]
        public string CodigoPrestamo { get; set; }

        [Required]
        [Display(Name = "Beneficiario Prestamo")]
        [StringLength(50,ErrorMessage ="Dime quien es el beneficiario")]
        public string Beneficiario  { get; set; }

        [Required(ErrorMessage ="Debes digitar cuanto te voy a prestar")]
        [Display(Name = "Valor Prestamo")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [Range(500,200000,ErrorMessage ="El valor desde estar entre 500 y 200k")]
        public Decimal ValorPrestamo  { get; set; }

        [Display(Name = "Emisor")]
        [StringLength(250)]
        public string Emisor { get; set; }

        [Required]
        [Display(Name = "Fecha Emision")]
        [DataType(DataType.Date)]
        public DateTime FechaEmision { get; set; }

        [Display(Name = "Tasa Emitida")]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Tasa { get; set; }

        [Display(Name = "Cantidad de Cuotas")]
        [Range(12,36,ErrorMessage ="Las cuotas deben ser 12 a 36")]
        public int CantidadCuotas { get; set; }

        [Display(Name = "Valor De Las Cuotas")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        public Decimal ValorCuotas { get; set; }

        [Display(Name = "Balance Actual")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [UIHint("ReadOnly")]
        public Decimal BalanceActual { get; set; }
        
        [Display(Name = "Observaciones")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string Observaciones { get; set; }

        public Cliente Cliente { get; set; }

    }
}