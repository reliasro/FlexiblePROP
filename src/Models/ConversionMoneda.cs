using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class ConversionMoneda         
    {
        public int ID { get; set; }

        [Display(Name = "Desde Moneda")]
        public int? MonedaOrigenID   { get; set; } //Evito el cascade DELETE con el optional ?
        
        [Display(Name = "Hacia Moneda")]
        public int? MonedaDestinoID  { get; set; }  //Evito el cascade DELETE con el optional ?

        public Moneda MonedaOrigen  { get; set; }
        public Moneda MonedaDestino  { get; set; }

        [Required]
        [Display(Name = "Factor Conversión")]
        [Column(TypeName = "decimal(10,2)")]
        public Decimal FactorConversion   { get; set; }

        [Required]
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaConversion { get; set; }
    }
}
