using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Propiedad
    {

        public int ID { get; set; }
        public Cliente Propietario { get; set; }
        public TipoPropiedad TipoPropiedad { get; set; }
        public IList<AreaPropiedad> AreasPropiedad { get; set; }
        public IList<ImagenPropiedad> Imagenes { get; set; }
        public IList<EquipoPropiedad> Equipos { get; set; }
        public IList<AvanceConstruccion> AvancesConstruccion { get; set; }
        public IList<Contrato> Contratos { get; set; }
        public IList<Seguro> Seguros { get; set; }
        public IList<TemaPendiente> TemasPendiente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Unidad UnidadEspacio { get; set; }
        public Moneda MonedaValores { get; set; }
        public ICollection<Medidor> Medidores { get; set; }

        [Display(Name ="Estado")]
        public EstadoPropiedad EstadoPropiedad  { get; set; }

        [Display(Name = "Propietario ")]
        public int? PropietarioID { get; set; } //Evito el DELETE CASCADE en esta relacion usando ?

        [Display(Name = "Tipo de Propiedad")]
        public int? TipoPropiedadID { get; set; } //Evito el DELETE CASCADE en esta relacion usando ?

        [Display(Name = "Vendedor ")]
        public int? VendedorID { get; set; } //Evito el DELETE CASCADE en esta relacion usando ?

        [Display(Name = "Unidad de Medida")]
        public int? UnidadID  { get; set; } //Evito el DELETE CASCADE en esta relacion usando ?

        [Display(Name = "Valores en Moneda:")]
        public int? MonedaID  { get; set; } //Evito el DELETE CASCADE en esta relacion usando ?

        [Required]
        [Display(Name = "Codigo")]
        [StringLength(50)]
        public string Codigo  { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion  { get; set; }

        [Display(Name = "Fecha Inicio Construccion")]
        [DataType(DataType.Date)]
        public DateTime FechaInicioConstruccion { get; set; }

        [Display(Name = "Fecha Fin Construccion")]
        [DataType(DataType.Date)]
        public DateTime FechaFinConstruccion  { get; set; }

        [Display(Name = "Costo Construcción/Remodelación")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoConstruccion  { get; set; }

        [Display(Name = "Metros Cuadrados")]
        [Range(90,400)]    
        public int MetrosConstruccion { get; set; }

        [StringLength(100)]
        public string Constructora   { get; set; }

        [Display(Name = "Fecha Venta")]
        [DataType(DataType.Date)]
        public DateTime FechaVenta { get; set; }

        [Display(Name = "Fecha Estimada Entrega")]
        [DataType(DataType.Date)]
        public DateTime FechaEntrega  { get; set; }

        [Display(Name = "Fecha Entrega Real")]
        [DataType(DataType.Date)]
        public DateTime FechaEntregaReal  { get; set; }

        [Display(Name = "Fecha Entrega Titulo")]
        [DataType(DataType.Date)]
        public DateTime FechaEntregaTitulo  { get; set; }

        [Display(Name = "Latitud")]
        [StringLength(50)]
        public string Latitud  { get; set; }

        [Display(Name = "Longitud")]
        [StringLength(50)]
        public string Longitud { get; set; }

        [Display(Name = "Estado Actual")]
        public int EstadoPropiedadID    { get; set; }

        [Display(Name = "Direccion En El Proyecto")]
        [StringLength(100)]
        public string DireccionEnProyecto  { get; set; }

        [Display(Name = "Precio De Lista")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioLista  { get; set; }

        [Display(Name = "Precio De Venta")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioVenta  { get; set; }

        [Display(Name = "Precio Renta Diario ")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioRentaDiario  { get; set; }

        [Display(Name = "Comision Venta (%)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Comision  { get; set; }

        [Display(Name = "Comision Renta (%)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ComisionRenta  { get; set; }

        [Display(Name = "Observaciones y Notas")]
        [StringLength(200)]
        public string Notas  { get; set; }

        [Display(Name = "Imagen")]
        [StringLength(200)]
        [DataType(DataType.ImageUrl)]
        public string FotoPropiedad   { get; set; }

        [Display(Name = "Esta Disponible Para renta?")]
        public Boolean DisponibleParaRenta  { get; set; }

        public string FichaPropiedad  { get { return ( "("+Codigo+") " + Descripcion ) ; }   }

    }
}
