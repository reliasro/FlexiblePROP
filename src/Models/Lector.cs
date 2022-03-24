using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Lector  
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Cedula")]
        [StringLength(15)]
        public string Cedula { get; set; }

        [Required]
        [Display(Name = "Direccion Residencia")]
        [StringLength(150)]
        public string Direccion  { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(20)]
        public string Telefono  { get; set; }

        [Display(Name = "Celular")]
        [StringLength(20)]
        public string Celular  { get; set; }

        [Display(Name = "Nombre Empresa")]
        [StringLength(100)]
        public string NombreEmpresa { get; set; }

        public ICollection<Itinerario> Itinerarios  { get; set; }

    }
}
