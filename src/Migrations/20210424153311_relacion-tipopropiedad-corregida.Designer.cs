﻿// <auto-generated />
using System;
using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContosoUniversity.Migrations
{
    [DbContext(typeof(FlexiblePROPContext))]
    [Migration("20210424153311_relacion-tipopropiedad-corregida")]
    partial class relaciontipopropiedadcorregida
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AreaPropiedadPropiedad", b =>
                {
                    b.Property<int>("AreasPropiedadID")
                        .HasColumnType("int");

                    b.Property<int>("PropiedadesID")
                        .HasColumnType("int");

                    b.HasKey("AreasPropiedadID", "PropiedadesID");

                    b.HasIndex("PropiedadesID");

                    b.ToTable("AreaPropiedadPropiedad");
                });

            modelBuilder.Entity("ContosoUniversity.Models.AreaPropiedad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("AreasPropiedades");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Casado")
                        .HasColumnType("bit");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Celular")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RolClienteID")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Website")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("RolClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Configuracion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DesdeFecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HastaFecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Modulo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Valor2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Configuraciones");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<byte[]>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int?>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Dependiente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Casado")
                        .HasColumnType("bit");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Celular")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ParentescoID")
                        .HasColumnType("int");

                    b.Property<int>("PropietarioID")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Website")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("ParentescoID");

                    b.ToTable("Dependientes");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Factura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BalanceActual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("CodigoFactura")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Emisor")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("LecturaFinal")
                        .HasColumnType("int");

                    b.Property<int>("LecturaInicial")
                        .HasColumnType("int");

                    b.Property<string>("Moneda")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("PropiedadID")
                        .HasColumnType("int");

                    b.Property<string>("PropietarioVilla")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Villa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("PropiedadID");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("ContosoUniversity.Models.GrupoPropiedad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("GruposPropiedades");
                });

            modelBuilder.Entity("ContosoUniversity.Models.ImagenPropiedad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreImagen")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("PropiedadID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PropiedadID");

                    b.ToTable("ImagenesPropiedades");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("ContosoUniversity.Models.OfficeAssignment", b =>
                {
                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InstructorID");

                    b.ToTable("OfficeAssignments");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Parentesco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Parentesco");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Prestamo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BalanceActual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Beneficiario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CantidadCuotas")
                        .HasColumnType("int");

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("CodigoPrestamo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Emisor")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal>("Tasa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorCuotas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorPrestamo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Propiedad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Comision")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Constructora")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("CostoConstruccion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DireccionEnProyecto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EstadoActual")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaEntregaTitulo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaFinConstruccion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicioConstruccion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<int>("Latitud")
                        .HasColumnType("int");

                    b.Property<int>("Longitud")
                        .HasColumnType("int");

                    b.Property<int>("MetrosConstruccion")
                        .HasColumnType("int");

                    b.Property<string>("Notas")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("PrecioLista")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropietarioID")
                        .HasColumnType("int");

                    b.Property<int>("TipoPropiedadID")
                        .HasColumnType("int");

                    b.Property<int>("VendedorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("TipoPropiedadID");

                    b.HasIndex("VendedorID");

                    b.ToTable("Propiedades");
                });

            modelBuilder.Entity("ContosoUniversity.Models.RolCliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("RolesClientes");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ContosoUniversity.Models.TipoPropiedad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GrupoPropiedadID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GrupoPropiedadID");

                    b.ToTable("TiposPropiedades");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Vendedor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Celular")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Inmobiliaria")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NombreEmpresa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Website")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("CourseInstructor", b =>
                {
                    b.Property<int>("CoursesCourseID")
                        .HasColumnType("int");

                    b.Property<int>("InstructorsID")
                        .HasColumnType("int");

                    b.HasKey("CoursesCourseID", "InstructorsID");

                    b.HasIndex("InstructorsID");

                    b.ToTable("CourseInstructor");
                });

            modelBuilder.Entity("AreaPropiedadPropiedad", b =>
                {
                    b.HasOne("ContosoUniversity.Models.AreaPropiedad", null)
                        .WithMany()
                        .HasForeignKey("AreasPropiedadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContosoUniversity.Models.Propiedad", null)
                        .WithMany()
                        .HasForeignKey("PropiedadesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContosoUniversity.Models.Cliente", b =>
                {
                    b.HasOne("ContosoUniversity.Models.RolCliente", "RolCliente")
                        .WithMany()
                        .HasForeignKey("RolClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RolCliente");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Course", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Department", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Instructor", "Administrator")
                        .WithMany()
                        .HasForeignKey("InstructorID");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Dependiente", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Cliente", "Cliente")
                        .WithMany("Dependientes")
                        .HasForeignKey("ClienteID");

                    b.HasOne("ContosoUniversity.Models.Parentesco", "Parentesco")
                        .WithMany()
                        .HasForeignKey("ParentescoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Parentesco");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Enrollment", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContosoUniversity.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Factura", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID");

                    b.HasOne("ContosoUniversity.Models.Propiedad", null)
                        .WithMany("Facturas")
                        .HasForeignKey("PropiedadID");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ContosoUniversity.Models.ImagenPropiedad", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Propiedad", "Propiedad")
                        .WithMany("Imagenes")
                        .HasForeignKey("PropiedadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propiedad");
                });

            modelBuilder.Entity("ContosoUniversity.Models.OfficeAssignment", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Instructor", "Instructor")
                        .WithOne("OfficeAssignment")
                        .HasForeignKey("ContosoUniversity.Models.OfficeAssignment", "InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Prestamo", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Propiedad", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Cliente", "Cliente")
                        .WithMany("Propiedades")
                        .HasForeignKey("ClienteID");

                    b.HasOne("ContosoUniversity.Models.TipoPropiedad", "TipoPropiedad")
                        .WithMany("Propiedades")
                        .HasForeignKey("TipoPropiedadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContosoUniversity.Models.Vendedor", "Vendedor")
                        .WithMany("PropiedadesVendidas")
                        .HasForeignKey("VendedorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TipoPropiedad");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("ContosoUniversity.Models.TipoPropiedad", b =>
                {
                    b.HasOne("ContosoUniversity.Models.GrupoPropiedad", "GrupoPropiedad")
                        .WithMany()
                        .HasForeignKey("GrupoPropiedadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoPropiedad");
                });

            modelBuilder.Entity("CourseInstructor", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContosoUniversity.Models.Instructor", null)
                        .WithMany()
                        .HasForeignKey("InstructorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContosoUniversity.Models.Cliente", b =>
                {
                    b.Navigation("Dependientes");

                    b.Navigation("Propiedades");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Department", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Instructor", b =>
                {
                    b.Navigation("OfficeAssignment");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Propiedad", b =>
                {
                    b.Navigation("Facturas");

                    b.Navigation("Imagenes");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("ContosoUniversity.Models.TipoPropiedad", b =>
                {
                    b.Navigation("Propiedades");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Vendedor", b =>
                {
                    b.Navigation("PropiedadesVendidas");
                });
#pragma warning restore 612, 618
        }
    }
}
