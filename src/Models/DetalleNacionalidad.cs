using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class DetalleNacionalidad   
    {
        public int ID { get; set; }

        //La clave se genera por fluent API
        public int NacionalidadID  { get; set; }
        public int ClienteID  { get; set; }

        public Nacionalidad Nacionalidad  { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        [Display(Name = "Numero Documento ")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

    }
}
