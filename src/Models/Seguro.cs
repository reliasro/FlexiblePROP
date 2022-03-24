using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Seguro     
    {
        public int ID { get; set; }
        public int PropiedadID { get; set; }
        public int TipoSeguroID   { get; set; }
        public int MonedaID  { get; set; }

        public Propiedad Propiedad { get; set; }

        [Display(Name = "Tipo Seguro")]
        public TipoSeguro TipoSeguro   { get; set; }

        [Display(Name = "Moneda")]
        public Moneda MonedaValorAsegurado  { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime Fecha  { get; set; }

        [Display(Name = "Vigencia Desde ")]
        [DataType(DataType.Date)]
        public DateTime VigenciaDesde { get; set; }

        [Display(Name = "Hasta")]
        [DataType(DataType.Date)]
        public DateTime VigenciaHasta { get; set; }

        [Display(Name = "Valor Asegurado")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorAsegurado  { get; set; }

    }
}
