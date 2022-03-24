using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Ciudad    
    {
        public int ID { get; set; }
        
        [Display(Name ="Seleccione El País")]
        public int PaisID  { get; set; }

        public Pais Pais  { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }

       // public string FichaCiudad  { get { return Pais.Descripcion + "> " + Descripcion; } }

        public IList<Municipio> Municipios  { get; set; }

    }
}
