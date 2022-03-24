using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Inmobiliaria  
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nombre ")]
        [StringLength(100)]
        public string Nombre   { get; set; }

        [Required]
        [Display(Name = "Direccion ")]
        [StringLength(200)]
        public string Direccion  { get; set; }

        [Required]
        [Display(Name = "Contacto Principal ")]
        [StringLength(100)]
        public string Contacto  { get; set; }

        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono  { get; set; }

        [Display(Name = "Cuenta Correo")]
        [DataType(DataType.EmailAddress)]
        public string Email  { get; set; }

        public string Descripcion  { get { return (Nombre + "(" + Contacto + ")"); }  }

    }
}
