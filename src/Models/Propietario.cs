using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Cliente 
    {
        public int ID { get; set; }

        [Display(Name ="Relación")]
        public int? RolClienteID  { get; set; }

        [Display(Name = "Pais Nacimiento")]
        public int? PaisID { get; set; }

        [Display(Name = "Sector Donde Vive")]
        public int? SectorID { get; set; }

        [Required]
        [Display(Name = "Codigo (uso interno)")]
        [StringLength(50)]
        public string Codigo  { get; set; }

        [Required]
        [Display(Name = "Primer Nombre")]
        [StringLength(100)]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        [StringLength(100)]
        public string SegundoNombre { get; set; }

        [Required]
        [Display(Name = "Primer Apellido")]
        [StringLength(100)]
        public string PrimerApellido  { get; set; }

        [Display(Name = "Segundo Apellido")]
        [StringLength(100)]
        public string SegundoApellido { get; set; }

        [Required]
        [Display(Name = "Cedula (sin guiones)")]
        [StringLength(11)]
        public string Cedula { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento  { get; set; }

        [Display(Name = "Alias")]
        [StringLength(50)]
        public string Alias  { get; set; }

        [Display(Name = "Sexo")]
        [StringLength(1)]
        public string Sexo  { get; set; }

        [Display(Name = "Calle")]
        [StringLength(100)]
        public string Calle  { get; set; }

        [Display(Name = "Edificio")]
        [StringLength(50)]
        public string Edificio { get; set; }

        [Display(Name = "Numero Casa/Apto")]
        [StringLength(50)]
        public string Numero  { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(20)]
        public string Telefono  { get; set; }

        [Display(Name = "Esta Casado?")]
        public Boolean Casado  { get; set; }

        [Display(Name = "Celular")]
        [StringLength(20)]
        public string Celular  { get; set; }
        
        [Display(Name = "Foto")]
        [StringLength(200)]
        [DataType(DataType.ImageUrl)]
        public string Foto  { get; set; }

        [StringLength(100)]
        public string Website     { get; set; }

        public string FichaPropietario  { get {return ("(" +Codigo+") "+ PrimerNombre + " "+PrimerApellido ); } }

        public ICollection<Propiedad> Propiedades  { get; set; }
        public ICollection<Dependiente> Dependientes  { get; set; }
        public RolCliente RolCliente { get; set; }
        public ICollection<Factura> Facturas { get; set; }
        public ICollection<DetalleNacionalidad> Nacionalidades { get; set; }
        public Pais  PaisNacimiento  { get; set; }
        public Sector SectorDondeVive  { get; set; }

    }
}
