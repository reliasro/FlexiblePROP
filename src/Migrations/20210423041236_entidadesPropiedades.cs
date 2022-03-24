using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class entidadesPropiedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreReal",
                table: "Propietarios",
                newName: "Nombre");

            migrationBuilder.AddColumn<bool>(
                name: "Casado",
                table: "Propietarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Propietarios",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Propietarios",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Propietarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Propietarios",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Propietarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Propietarios",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "website",
                table: "Propietarios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropiedadID",
                table: "Facturas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AreasPropiedades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasPropiedades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GruposPropiedades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposPropiedades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposPropiedades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPropiedades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Inmobiliaria = table.Column<bool>(type: "bit", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Propiedades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropietarioID = table.Column<int>(type: "int", nullable: false),
                    TipoPropiedadID = table.Column<int>(type: "int", nullable: false),
                    GrupoPropiedadID = table.Column<int>(type: "int", nullable: false),
                    VendedorID = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaInicioConstruccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinConstruccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CostoConstruccion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MetrosConstruccion = table.Column<int>(type: "int", nullable: false),
                    Constructora = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntregaTitulo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Latitud = table.Column<int>(type: "int", nullable: false),
                    Longitud = table.Column<int>(type: "int", nullable: false),
                    EstadoActual = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DireccionEnProyecto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PrecioLista = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comision = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Propiedades_GruposPropiedades_GrupoPropiedadID",
                        column: x => x.GrupoPropiedadID,
                        principalTable: "GruposPropiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Propiedades_Propietarios_PropietarioID",
                        column: x => x.PropietarioID,
                        principalTable: "Propietarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Propiedades_TiposPropiedades_TipoPropiedadID",
                        column: x => x.TipoPropiedadID,
                        principalTable: "TiposPropiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Propiedades_Vendedores_VendedorID",
                        column: x => x.VendedorID,
                        principalTable: "Vendedores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AreaPropiedadPropiedad",
                columns: table => new
                {
                    AreasPropiedadID = table.Column<int>(type: "int", nullable: false),
                    PropiedadesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPropiedadPropiedad", x => new { x.AreasPropiedadID, x.PropiedadesID });
                    table.ForeignKey(
                        name: "FK_AreaPropiedadPropiedad_AreasPropiedades_AreasPropiedadID",
                        column: x => x.AreasPropiedadID,
                        principalTable: "AreasPropiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaPropiedadPropiedad_Propiedades_PropiedadesID",
                        column: x => x.PropiedadesID,
                        principalTable: "Propiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagenesPropiedades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreImagen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PropiedadID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenesPropiedades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ImagenesPropiedades_Propiedades_PropiedadID",
                        column: x => x.PropiedadID,
                        principalTable: "Propiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_PropiedadID",
                table: "Facturas",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPropiedadPropiedad_PropiedadesID",
                table: "AreaPropiedadPropiedad",
                column: "PropiedadesID");

            migrationBuilder.CreateIndex(
                name: "IX_ImagenesPropiedades_PropiedadID",
                table: "ImagenesPropiedades",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_GrupoPropiedadID",
                table: "Propiedades",
                column: "GrupoPropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_PropietarioID",
                table: "Propiedades",
                column: "PropietarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_TipoPropiedadID",
                table: "Propiedades",
                column: "TipoPropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_VendedorID",
                table: "Propiedades",
                column: "VendedorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Propiedades_PropiedadID",
                table: "Facturas",
                column: "PropiedadID",
                principalTable: "Propiedades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Propiedades_PropiedadID",
                table: "Facturas");

            migrationBuilder.DropTable(
                name: "AreaPropiedadPropiedad");

            migrationBuilder.DropTable(
                name: "ImagenesPropiedades");

            migrationBuilder.DropTable(
                name: "AreasPropiedades");

            migrationBuilder.DropTable(
                name: "Propiedades");

            migrationBuilder.DropTable(
                name: "GruposPropiedades");

            migrationBuilder.DropTable(
                name: "TiposPropiedades");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_PropiedadID",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Casado",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "website",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "PropiedadID",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Propietarios",
                newName: "NombreReal");
        }
    }
}
