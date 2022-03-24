using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class prestamos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPrestamo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Beneficiario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ValorPrestamo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Emisor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tasa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CantidadCuotas = table.Column<int>(type: "int", nullable: false),
                    ValorCuotas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BalanceActual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestamos");
        }
    }
}
