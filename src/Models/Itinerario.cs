using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Itinerario   
    {
        //Es una llave compuesta 
        public int RutaID   { get; set; }
        public int LectorID  { get; set; }
        public int MedidorID  { get; set; }

        [Required(ErrorMessage ="Indique el orden de lectura")]
        [Display(Name = "Orden Lectura")]
        [Range(1,200)]
        public int OrdenLectura   { get; set; }

        public Lector Lector { get; set; }
        public Medidor Medidor  { get; set; }
        public Ruta Ruta { get; set; }

    }
}
