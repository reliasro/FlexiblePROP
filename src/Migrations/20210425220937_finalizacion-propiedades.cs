using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class finalizacionpropiedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_RolesClientes_RolClienteID",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "AreaPropiedadPropiedad");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Clientes",
                newName: "PrimerNombre");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Clientes",
                newName: "PrimerApellido");

            migrationBuilder.AddColumn<decimal>(
                name: "ComisionRenta",
                table: "Propiedades",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "DisponibleParaRenta",
                table: "Propiedades",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEntregaReal",
                table: "Propiedades",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioRentaDiario",
                table: "Propiedades",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "MediosComunicacion",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "RolClienteID",
                table: "Clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Clientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Calle",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Edificio",
                table: "Clientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Clientes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Clientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaisID",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectorID",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoNombre",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Clientes",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CantidadEspacio",
                table: "AreasPropiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropiedadID",
                table: "AreasPropiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadID",
                table: "AreasPropiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AvancesConstruccion",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropiedadID = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PorcentajeAvance = table.Column<decimal>(type: "decimal(3,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvancesConstruccion", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AvancesConstruccion_Propiedades_PropiedadID",
                        column: x => x.PropiedadID,
                        principalTable: "Propiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposContrato",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposContrato", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposSeguro",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposSeguro", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosNacionales",
                columns: table => new
                {
                    NacionalidadID = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosNacionales", x => new { x.ClienteID, x.NacionalidadID });
                    table.ForeignKey(
                        name: "FK_DocumentosNacionales_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentosNacionales_Nacionalidades_NacionalidadID",
                        column: x => x.NacionalidadID,
                        principalTable: "Nacionalidades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisID = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ciudades_Paises_PaisID",
                        column: x => x.PaisID,
                        principalTable: "Paises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropiedadID = table.Column<int>(type: "int", nullable: false),
                    TipoContratoID = table.Column<int>(type: "int", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFirma = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Firmado = table.Column<bool>(type: "bit", nullable: false),
                    Legalizado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contratos_Propiedades_PropiedadID",
                        column: x => x.PropiedadID,
                        principalTable: "Propiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratos_TiposContrato_TipoContratoID",
                        column: x => x.TipoContratoID,
                        principalTable: "TiposContrato",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemasPendientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropiedadID = table.Column<int>(type: "int", nullable: false),
                    TipoContratoID = table.Column<int>(type: "int", nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaReporte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemasPendientes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TemasPendientes_Propiedades_PropiedadID",
                        column: x => x.PropiedadID,
                        principalTable: "Propiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemasPendientes_TiposContrato_TipoContratoID",
                        column: x => x.TipoContratoID,
                        principalTable: "TiposContrato",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropiedadID = table.Column<int>(type: "int", nullable: false),
                    TipoSeguroID = table.Column<int>(type: "int", nullable: false),
                    MonedaID = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VigenciaDesde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VigenciaHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorAsegurado = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Seguros_Monedas_MonedaID",
                        column: x => x.MonedaID,
                        principalTable: "Monedas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguros_Propiedades_PropiedadID",
                        column: x => x.PropiedadID,
                        principalTable: "Propiedades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguros_TiposSeguro_TipoSeguroID",
                        column: x => x.TipoSeguroID,
                        principalTable: "TiposSeguro",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiudadID = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Municipios_Ciudades_CiudadID",
                        column: x => x.CiudadID,
                        principalTable: "Ciudades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipioID = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sectores_Municipios_MunicipioID",
                        column: x => x.MunicipioID,
                        principalTable: "Municipios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PaisID",
                table: "Clientes",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_SectorID",
                table: "Clientes",
                column: "SectorID");

            migrationBuilder.CreateIndex(
                name: "IX_AreasPropiedades_PropiedadID",
                table: "AreasPropiedades",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_AreasPropiedades_UnidadID",
                table: "AreasPropiedades",
                column: "UnidadID");

            migrationBuilder.CreateIndex(
                name: "IX_AvancesConstruccion_PropiedadID",
                table: "AvancesConstruccion",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_PaisID",
                table: "Ciudades",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_PropiedadID",
                table: "Contratos",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_TipoContratoID",
                table: "Contratos",
                column: "TipoContratoID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosNacionales_NacionalidadID",
                table: "DocumentosNacionales",
                column: "NacionalidadID");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_CiudadID",
                table: "Municipios",
                column: "CiudadID");

            migrationBuilder.CreateIndex(
                name: "IX_Sectores_MunicipioID",
                table: "Sectores",
                column: "MunicipioID");

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_MonedaID",
                table: "Seguros",
                column: "MonedaID");

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_PropiedadID",
                table: "Seguros",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_TipoSeguroID",
                table: "Seguros",
                column: "TipoSeguroID");

            migrationBuilder.CreateIndex(
                name: "IX_TemasPendientes_PropiedadID",
                table: "TemasPendientes",
                column: "PropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_TemasPendientes_TipoContratoID",
                table: "TemasPendientes",
                column: "TipoContratoID");

            migrationBuilder.AddForeignKey(
                name: "FK_AreasPropiedades_Propiedades_PropiedadID",
                table: "AreasPropiedades",
                column: "PropiedadID",
                principalTable: "Propiedades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AreasPropiedades_Unidades_UnidadID",
                table: "AreasPropiedades",
                column: "UnidadID",
                principalTable: "Unidades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Paises_PaisID",
                table: "Clientes",
                column: "PaisID",
                principalTable: "Paises",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_RolesClientes_RolClienteID",
                table: "Clientes",
                column: "RolClienteID",
                principalTable: "RolesClientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Sectores_SectorID",
                table: "Clientes",
                column: "SectorID",
                principalTable: "Sectores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreasPropiedades_Propiedades_PropiedadID",
                table: "AreasPropiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_AreasPropiedades_Unidades_UnidadID",
                table: "AreasPropiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Paises_PaisID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_RolesClientes_RolClienteID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Sectores_SectorID",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "AvancesConstruccion");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "DocumentosNacionales");

            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "Seguros");

            migrationBuilder.DropTable(
                name: "TemasPendientes");

            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Nacionalidades");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Monedas");

            migrationBuilder.DropTable(
                name: "TiposSeguro");

            migrationBuilder.DropTable(
                name: "TiposContrato");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PaisID",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_SectorID",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_AreasPropiedades_PropiedadID",
                table: "AreasPropiedades");

            migrationBuilder.DropIndex(
                name: "IX_AreasPropiedades_UnidadID",
                table: "AreasPropiedades");

            migrationBuilder.DropColumn(
                name: "ComisionRenta",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "DisponibleParaRenta",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "FechaEntregaReal",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "PrecioRentaDiario",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "MediosComunicacion");

            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Calle",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Edificio",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PaisID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "SectorID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "SegundoNombre",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CantidadEspacio",
                table: "AreasPropiedades");

            migrationBuilder.DropColumn(
                name: "PropiedadID",
                table: "AreasPropiedades");

            migrationBuilder.DropColumn(
                name: "UnidadID",
                table: "AreasPropiedades");

            migrationBuilder.RenameColumn(
                name: "PrimerNombre",
                table: "Clientes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "PrimerApellido",
                table: "Clientes",
                newName: "Apellidos");

            migrationBuilder.AlterColumn<int>(
                name: "RolClienteID",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Clientes",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_AreaPropiedadPropiedad_PropiedadesID",
                table: "AreaPropiedadPropiedad",
                column: "PropiedadesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_RolesClientes_RolClienteID",
                table: "Clientes",
                column: "RolClienteID",
                principalTable: "RolesClientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
