using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class entidadeslecturafacturacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Propiedades_PropiedadID",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_PropiedadID",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Inmobiliaria",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "PropiedadID",
                table: "Facturas");

            migrationBuilder.AddColumn<int>(
                name: "InmobiliariaID",
                table: "Vendedores",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Longitud",
                table: "Propiedades",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Latitud",
                table: "Propiedades",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Anomalias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anomalias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GruposCompania",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposCompania", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inmobiliarias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmobiliarias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lectores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposMedidores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMedidores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposRutas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposRutas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Companias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupoCompaniaID = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Companias_GruposCompania_GrupoCompaniaID",
                        column: x => x.GrupoCompaniaID,
                        principalTable: "GruposCompania",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medidores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMedidorID = table.Column<int>(type: "int", nullable: false),
                    PropiedadID = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Serie = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaInstalacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LecturaInstalacion = table.Column<int>(type: "int", nullable: false),
                    UltimaLectura = table.Column<int>(type: "int", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medidores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Medidores_Propiedades_PropiedadID",
                        column: x => x.PropiedadID,
                        principalTable: "Propiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medidores_TiposMedidores_TipoMedidorID",
                        column: x => x.TipoMedidorID,
                        principalTable: "TiposMedidores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoRutaID = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaLectura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rutas_TiposRutas_TipoRutaID",
                        column: x => x.TipoRutaID,
                        principalTable: "TiposRutas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediosComunicacion",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompaniaID = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediosComunicacion", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MediosComunicacion_Companias_CompaniaID",
                        column: x => x.CompaniaID,
                        principalTable: "Companias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Itinerarios",
                columns: table => new
                {
                    LectorID = table.Column<int>(type: "int", nullable: false),
                    MedidorID = table.Column<int>(type: "int", nullable: false),
                    RutaID = table.Column<int>(type: "int", nullable: false),
                    OrdenLectura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerarios", x => new { x.LectorID, x.MedidorID });
                    table.ForeignKey(
                        name: "FK_Itinerarios_Lectores_LectorID",
                        column: x => x.LectorID,
                        principalTable: "Lectores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itinerarios_Medidores_MedidorID",
                        column: x => x.MedidorID,
                        principalTable: "Medidores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itinerarios_Rutas_RutaID",
                        column: x => x.RutaID,
                        principalTable: "Rutas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lecturas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedidorID = table.Column<int>(type: "int", nullable: false),
                    LectorID = table.Column<int>(type: "int", nullable: false),
                    RutaID = table.Column<int>(type: "int", nullable: false),
                    FacturaID = table.Column<int>(type: "int", nullable: true),
                    AnomaliaID = table.Column<int>(type: "int", nullable: true),
                    PropiedaID = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Serie = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaProgramada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaReal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrdenLectura = table.Column<int>(type: "int", nullable: false),
                    LecturaAnterior = table.Column<int>(type: "int", nullable: false),
                    LecturaTomada = table.Column<int>(type: "int", nullable: false),
                    ConsumoFacturado = table.Column<int>(type: "int", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EstaFacturado = table.Column<bool>(type: "bit", nullable: false),
                    Latitud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Longitud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PropiedadID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lecturas_Anomalias_AnomaliaID",
                        column: x => x.AnomaliaID,
                        principalTable: "Anomalias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lecturas_Facturas_FacturaID",
                        column: x => x.FacturaID,
                        principalTable: "Facturas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lecturas_Lectores_LectorID",
                        column: x => x.LectorID,
                        principalTable: "Lectores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lecturas_Medidores_MedidorID",
                        column: x => x.MedidorID,
                        principalTable: "Medidores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lecturas_Propiedades_PropiedadID",
                        column: x => x.PropiedadID,
                        principalTable: "Propiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lecturas_Rutas_RutaID",
                        column: x => x.RutaID,
                        principalTable: "Rutas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_InmobiliariaID",
                table: "Vendedores",
                column: "InmobiliariaID");

            migrationBuilder.CreateIndex(
                name: "IX_Companias_GrupoCompaniaID",
                table: "Companias",
                column: "GrupoCompaniaID");

            migrationBuilder.CreateIndex(
                name: "IX_Itinerarios_MedidorID",
                table: "Itinerarios",
                column: "MedidorID");

            migrationBuilder.CreateIndex(
                name: "IX_Itinerarios_RutaID",
                table: "Itinerarios",
                column: "RutaID");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_AnomaliaID",
                table: "Lecturas",
                column: "AnomaliaID");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_FacturaID",
                table: "Lecturas",
                column: "FacturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_LectorID",
                table: "Lecturas",
                column: "LectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_MedidorID",
                table: "Lecturas",
                column: "MedidorID");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_PropiedadID",
                table: "Lecturas",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_RutaID",
                table: "Lecturas",
                column: "RutaID");

            migrationBuilder.CreateIndex(
                name: "IX_Medidores_PropiedadID",
                table: "Medidores",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Medidores_TipoMedidorID",
                table: "Medidores",
                column: "TipoMedidorID");

            migrationBuilder.CreateIndex(
                name: "IX_MediosComunicacion_CompaniaID",
                table: "MediosComunicacion",
                column: "CompaniaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rutas_TipoRutaID",
                table: "Rutas",
                column: "TipoRutaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedores_Inmobiliarias_InmobiliariaID",
                table: "Vendedores",
                column: "InmobiliariaID",
                principalTable: "Inmobiliarias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedores_Inmobiliarias_InmobiliariaID",
                table: "Vendedores");

            migrationBuilder.DropTable(
                name: "Inmobiliarias");

            migrationBuilder.DropTable(
                name: "Itinerarios");

            migrationBuilder.DropTable(
                name: "Lecturas");

            migrationBuilder.DropTable(
                name: "MediosComunicacion");

            migrationBuilder.DropTable(
                name: "Anomalias");

            migrationBuilder.DropTable(
                name: "Lectores");

            migrationBuilder.DropTable(
                name: "Medidores");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropTable(
                name: "Companias");

            migrationBuilder.DropTable(
                name: "TiposMedidores");

            migrationBuilder.DropTable(
                name: "TiposRutas");

            migrationBuilder.DropTable(
                name: "GruposCompania");

            migrationBuilder.DropIndex(
                name: "IX_Vendedores_InmobiliariaID",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "InmobiliariaID",
                table: "Vendedores");

            migrationBuilder.AddColumn<bool>(
                name: "Inmobiliaria",
                table: "Vendedores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Longitud",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Latitud",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropiedadID",
                table: "Facturas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_PropiedadID",
                table: "Facturas",
                column: "PropiedadID");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Propiedades_PropiedadID",
                table: "Facturas",
                column: "PropiedadID",
                principalTable: "Propiedades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
