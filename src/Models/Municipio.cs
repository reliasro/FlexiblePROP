using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Municipio     
    {
        public int ID { get; set; }

        [Display(Name = "Seleccione La Ciudad")]
        public int CiudadID  { get; set; }

        public Ciudad Ciudad { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }

       // public string FichaMunicipio  { get { return Ciudad.Descripcion +"> "+Descripcion ; } }

        public IList<Sector> Sectores  { get; set; }

    }
}
