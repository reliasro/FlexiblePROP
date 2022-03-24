using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class cambiosmenores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConversionesMonedas_Monedas_MonenaDestinoID",
                table: "ConversionesMonedas");

            migrationBuilder.DropForeignKey(
                name: "FK_ConversionesMonedas_Monedas_MonenaOrigenID",
                table: "ConversionesMonedas");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Clientes_ClienteID",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_ClienteID",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_ConversionesMonedas_MonenaDestinoID",
                table: "ConversionesMonedas");

            migrationBuilder.DropIndex(
                name: "IX_ConversionesMonedas_MonenaOrigenID",
                table: "ConversionesMonedas");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "MonenaDestinoID",
                table: "ConversionesMonedas");

            migrationBuilder.DropColumn(
                name: "MonenaOrigenID",
                table: "ConversionesMonedas");

            migrationBuilder.AddColumn<string>(
                name: "FotoPropiedad",
                table: "Propiedades",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_PropietarioID",
                table: "Propiedades",
                column: "PropietarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Clientes_PropietarioID",
                table: "Propiedades",
                column: "PropietarioID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Clientes_PropietarioID",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_PropietarioID",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "FotoPropiedad",
                table: "Propiedades");

            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "Propiedades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonenaDestinoID",
                table: "ConversionesMonedas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonenaOrigenID",
                table: "ConversionesMonedas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_ClienteID",
                table: "Propiedades",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_ConversionesMonedas_MonenaDestinoID",
                table: "ConversionesMonedas",
                column: "MonenaDestinoID");

            migrationBuilder.CreateIndex(
                name: "IX_ConversionesMonedas_MonenaOrigenID",
                table: "ConversionesMonedas",
                column: "MonenaOrigenID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConversionesMonedas_Monedas_MonenaDestinoID",
                table: "ConversionesMonedas",
                column: "MonenaDestinoID",
                principalTable: "Monedas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConversionesMonedas_Monedas_MonenaOrigenID",
                table: "ConversionesMonedas",
                column: "MonenaOrigenID",
                principalTable: "Monedas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Clientes_ClienteID",
                table: "Propiedades",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
