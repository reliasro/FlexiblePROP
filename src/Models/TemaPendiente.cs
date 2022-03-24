using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class TemaPendiente     
    {
        public int ID { get; set; }
        public int PropiedadID { get; set; }
        public int TipoContratoID  { get; set; }

        public Propiedad Propiedad { get; set; }

        [Display(Name = "Tipo Contrato")]
        public TipoContrato TipoContrato  { get; set; }

        [Required]
        [Display(Name = "Tema")]
        [StringLength(100)]
        public string Tema { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Display(Name = "Fecha Reporte")]
        [DataType(DataType.Date)]
        public DateTime FechaReporte    { get; set; }

        [Display(Name = "Estatus")]
        [StringLength(20)]
        public string Estatus   { get; set; }

    }
}
