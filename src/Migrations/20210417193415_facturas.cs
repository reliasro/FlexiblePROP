using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class facturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoFactura = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Villa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PropietarioVilla = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ValorFactura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Emisor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Moneda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LecturaInicial = table.Column<int>(type: "int", nullable: false),
                    LecturaFinal = table.Column<int>(type: "int", nullable: false),
                    BalanceActual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");
        }
    }
}
