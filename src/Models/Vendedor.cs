using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Vendedor 
    {
        public int ID { get; set; }

        [Display(Name = "Inmobiliaria")]
        public int? InmobiliariaID  { get; set; }

        [Required]
        [Display(Name = "Codigo (uso interno)")]
        [StringLength(50)]
        public string Codigo  { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Cedula o RNC ")]
        [StringLength(15)]
        public string Cedula { get; set; }

        [Required]
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento  { get; set; } 

        [Required]
        [Display(Name = "Direccion ")]
        [StringLength(150)]
        public string Direccion  { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(20)]
        public string Telefono  { get; set; }

        [Display(Name = "Celular")]
        [StringLength(20)]
        public string Celular  { get; set; }

        [StringLength(100)]
        public string Website   { get; set; }

        [Display(Name = "Nombre Empresa")]
        [StringLength(100)]
        public string NombreEmpresa { get; set; }

        public string FichaVendedor  { get {return ("("+Codigo+") " + Nombre+" "+Apellidos)  ; }  }

        public ICollection<Propiedad> PropiedadesVendidas  { get; set; }
        public Inmobiliaria Inmobiliaria  { get; set; }

    }
}
