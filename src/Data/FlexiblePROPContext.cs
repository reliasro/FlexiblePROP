using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class FlexiblePROPContext : DbContext
    {
        public FlexiblePROPContext(DbContextOptions<FlexiblePROPContext> options) : base(options)
        {
        }

        public enum ModulosConfiguracion { CuentaxCobrar,Facturacion, Prestamo, Propiedad, Propietario,Renta, Servicio, Ventas, Comprobantes }
        public DbSet<Cliente> Clientes   { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Factura> Facturas  { get; set; }
        public DbSet<Configuracion> Configuraciones  { get; set; }
        public DbSet<AreaPropiedad> AreasPropiedades  { get; set; }
        public DbSet<GrupoPropiedad> GruposPropiedades { get; set; }
        public DbSet<ImagenPropiedad> ImagenesPropiedades { get; set; }
        public DbSet<Propiedad> Propiedades { get; set; }
        public DbSet<TipoPropiedad> TiposPropiedades  { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<RolCliente> RolesClientes   { get; set; }
        public DbSet<Dependiente> Dependientes  { get; set; }
        public DbSet<Inmobiliaria> Inmobiliarias  { get; set; }
        public DbSet<Ruta> Rutas  { get; set; }
        public DbSet<Lector> Lectores  { get; set; }
        public DbSet<TipoRuta> TiposRutas  { get; set; }
        public DbSet<Medidor> Medidores  { get; set; }
        public DbSet<TipoMedidor> TiposMedidores   { get; set; }
        public DbSet<Compania> Companias { get; set; }
        public DbSet<Itinerario> Itinerarios  { get; set; }
        public DbSet<Lectura> Lecturas  { get; set; }
        public DbSet<Anomalia> Anomalias  { get; set; }
        public DbSet<MedioComunicacion> MediosComunicacion { get; set; }
        public DbSet<GrupoCompania> GruposCompania  { get; set; }
        public DbSet<EquipoPropiedad> EquiposPropiedad  { get; set; }
        public DbSet<Unidad> Unidades  { get; set; }
        public DbSet<Moneda> Monedas  { get; set; }
        public DbSet<AvanceConstruccion> AvancesConstruccion { get; set; }
        public DbSet<Contrato> Contratos  { get; set; }
        public DbSet<TipoContrato> TiposContrato  { get; set; }
        public DbSet<Seguro> Seguros  { get; set; }
        public DbSet<TipoSeguro> TiposSeguro  { get; set; }
        public DbSet<TemaPendiente> TemasPendientes  { get; set; }
        public DbSet<Nacionalidad> Nacionalidades  { get; set; }
        public DbSet<DetalleNacionalidad> DocumentosNacionales  { get; set; }
        public DbSet<Pais> Paises  { get; set; }
        public DbSet<Ciudad> Ciudades  { get; set; }
        public DbSet<Municipio> Municipios  { get; set; }
        public DbSet<Sector> Sectores  { get; set; }
        public DbSet<ConversionMoneda> ConversionesMonedas   { get; set; }
        public DbSet<EstadoPropiedad> EstadoPropiedad { get; set; } //pendiente regenerar CRUD
        public DbSet<Parentesco> Parentesco  { get; set; } //pendiente regenerar CRUD

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable(nameof(Course))
                .HasMany(c => c.Instructors)
                .WithMany(i => i.Courses);
            modelBuilder.Entity<Student>().ToTable(nameof(Student));
            modelBuilder.Entity<Instructor>().ToTable(nameof(Instructor));

            modelBuilder.Entity<Itinerario>()
            .HasKey(c => new { c.LectorID, c.MedidorID });

          /*  modelBuilder.Entity<DetalleNacionalidad>()
            .HasKey(c => new { c.ClienteID, c.NacionalidadID });
          */
        }


    }
}
