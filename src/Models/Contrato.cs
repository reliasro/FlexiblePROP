using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Contrato    
    {
        public int ID { get; set; }

        [Display(Name = "Propiedad")]
        public int PropiedadID { get; set; }

        [Display(Name = "Tipo Contrato")]
        public int TipoContratoID  { get; set; }

        [Required]
        [Display(Name = "Propiedad")]
        public Propiedad Propiedad { get; set; }

        [Required]
        [Display(Name = "Tipo Contrato")]
        public TipoContrato TipoContrato  { get; set; }

        [Required]
        [Display(Name = "Descripcion Breve")]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Display(Name = "Fecha Entrega Cliente")]
        [DataType(DataType.Date)]
        public DateTime FechaEntrega   { get; set; }

        [Display(Name = "Fecha Firma")]
        [DataType(DataType.Date)]
        public DateTime FechaFirma  { get; set; }

        [Display(Name = "Contrato Firmado?")]
        public Boolean Firmado   { get; set; }

        [Display(Name = "Contrato Legalizado?")]
        public Boolean Legalizado  { get; set; }

    }
}
