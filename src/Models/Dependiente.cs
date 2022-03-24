using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Dependiente 
    {
        public int ID { get; set; }
        public int PropietarioID   { get; set; }
        public int ParentescoID  { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Cedula (sin guiones)")]
        [StringLength(11)]
        public string Cedula { get; set; }

        [Required]
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento  { get; set; }

        [Required]
        [Display(Name = "Direccion Casa")]
        [StringLength(150)]
        public string Direccion  { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(20)]
        public string Telefono  { get; set; }

        [Display(Name = "Esta Casado?")]
        public Boolean Casado  { get; set; }

        [Display(Name = "Celular")]
        [StringLength(20)]
        public string Celular  { get; set; }

        [StringLength(100)]
        public string Website     { get; set; }

        public Cliente Cliente  { get; set; }
        public Parentesco Parentesco  { get; set; }
    }
}
