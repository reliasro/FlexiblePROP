using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class MedioComunicacion   
    {
        public int ID { get; set; }

        [Display(Name = "Compania")]
        public int CompaniaID  { get; set; }

        [Required]
        [Display(Name = "Medio (Website, telefono, etc,)")]
        [StringLength(100)]
        public string Descripcion  { get; set; }

        [Required]
        [Display(Name = "Indique datos del medio")]
        [StringLength(100)]
        public string Valor  { get; set; }

        public Compania Compania { get; set; }

    }
}
