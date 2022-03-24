using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class factorconversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_TiposPropiedades_TipoPropiedadID",
                table: "Propiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Vendedores_VendedorID",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "EstadoActual",
                table: "Propiedades");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorID",
                table: "Propiedades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TipoPropiedadID",
                table: "Propiedades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PropietarioID",
                table: "Propiedades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EstadoPropiedadID",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonedaID",
                table: "Propiedades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnidadID",
                table: "Propiedades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ConversionesMonedas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonenaOrigenID = table.Column<int>(type: "int", nullable: true),
                    MonenaDestinoID = table.Column<int>(type: "int", nullable: true),
                    MonedaOrigenID = table.Column<int>(type: "int", nullable: true),
                    MonedaDestinoID = table.Column<int>(type: "int", nullable: true),
                    FactorConversion = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    FechaConversion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversionesMonedas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ConversionesMonedas_Monedas_MonedaDestinoID",
                        column: x => x.MonedaDestinoID,
                        principalTable: "Monedas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConversionesMonedas_Monedas_MonedaOrigenID",
                        column: x => x.MonedaOrigenID,
                        principalTable: "Monedas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConversionesMonedas_Monedas_MonenaDestinoID",
                        column: x => x.MonenaDestinoID,
                        principalTable: "Monedas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConversionesMonedas_Monedas_MonenaOrigenID",
                        column: x => x.MonenaOrigenID,
                        principalTable: "Monedas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPropiedad",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPropiedad", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_EstadoPropiedadID",
                table: "Propiedades",
                column: "EstadoPropiedadID");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_MonedaID",
                table: "Propiedades",
                column: "MonedaID");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_UnidadID",
                table: "Propiedades",
                column: "UnidadID");

            migrationBuilder.CreateIndex(
                name: "IX_ConversionesMonedas_MonedaDestinoID",
                table: "ConversionesMonedas",
                column: "MonedaDestinoID");

            migrationBuilder.CreateIndex(
                name: "IX_ConversionesMonedas_MonedaOrigenID",
                table: "ConversionesMonedas",
                column: "MonedaOrigenID");

            migrationBuilder.CreateIndex(
                name: "IX_ConversionesMonedas_MonenaDestinoID",
                table: "ConversionesMonedas",
                column: "MonenaDestinoID");

            migrationBuilder.CreateIndex(
                name: "IX_ConversionesMonedas_MonenaOrigenID",
                table: "ConversionesMonedas",
                column: "MonenaOrigenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_EstadoPropiedad_EstadoPropiedadID",
                table: "Propiedades",
                column: "EstadoPropiedadID",
                principalTable: "EstadoPropiedad",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Monedas_MonedaID",
                table: "Propiedades",
                column: "MonedaID",
                principalTable: "Monedas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_TiposPropiedades_TipoPropiedadID",
                table: "Propiedades",
                column: "TipoPropiedadID",
                principalTable: "TiposPropiedades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Unidades_UnidadID",
                table: "Propiedades",
                column: "UnidadID",
                principalTable: "Unidades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Vendedores_VendedorID",
                table: "Propiedades",
                column: "VendedorID",
                principalTable: "Vendedores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_EstadoPropiedad_EstadoPropiedadID",
                table: "Propiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Monedas_MonedaID",
                table: "Propiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_TiposPropiedades_TipoPropiedadID",
                table: "Propiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Unidades_UnidadID",
                table: "Propiedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Vendedores_VendedorID",
                table: "Propiedades");

            migrationBuilder.DropTable(
                name: "ConversionesMonedas");

            migrationBuilder.DropTable(
                name: "EstadoPropiedad");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_EstadoPropiedadID",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_MonedaID",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_UnidadID",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "EstadoPropiedadID",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "MonedaID",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "UnidadID",
                table: "Propiedades");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorID",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoPropiedadID",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PropietarioID",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoActual",
                table: "Propiedades",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_TiposPropiedades_TipoPropiedadID",
                table: "Propiedades",
                column: "TipoPropiedadID",
                principalTable: "TiposPropiedades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Vendedores_VendedorID",
                table: "Propiedades",
                column: "VendedorID",
                principalTable: "Vendedores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
