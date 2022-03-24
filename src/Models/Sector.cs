using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Sector      
    {
        public int ID { get; set; }

        [Display(Name = "Seleccione El Municipio")]
        public int MunicipioID   { get; set; }

        public Municipio Municipio  { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }

      //  public string FichaSector    { get {return Municipio.FichaMunicipio+"> "+Descripcion ; }  }

        public IList<Cliente> Clientes { get; set; }

    }
}
