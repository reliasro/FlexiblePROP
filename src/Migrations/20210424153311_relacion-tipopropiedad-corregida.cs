using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class relaciontipopropiedadcorregida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_GruposPropiedades_GrupoPropiedadID",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_GrupoPropiedadID",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "GrupoPropiedadID",
                table: "Propiedades");

            migrationBuilder.AddColumn<int>(
                name: "GrupoPropiedadID",
                table: "TiposPropiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TiposPropiedades_GrupoPropiedadID",
                table: "TiposPropiedades",
                column: "GrupoPropiedadID");

            migrationBuilder.AddForeignKey(
                name: "FK_TiposPropiedades_GruposPropiedades_GrupoPropiedadID",
                table: "TiposPropiedades",
                column: "GrupoPropiedadID",
                principalTable: "GruposPropiedades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TiposPropiedades_GruposPropiedades_GrupoPropiedadID",
                table: "TiposPropiedades");

            migrationBuilder.DropIndex(
                name: "IX_TiposPropiedades_GrupoPropiedadID",
                table: "TiposPropiedades");

            migrationBuilder.DropColumn(
                name: "GrupoPropiedadID",
                table: "TiposPropiedades");

            migrationBuilder.AddColumn<int>(
                name: "GrupoPropiedadID",
                table: "Propiedades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_GrupoPropiedadID",
                table: "Propiedades",
                column: "GrupoPropiedadID");

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_GruposPropiedades_GrupoPropiedadID",
                table: "Propiedades",
                column: "GrupoPropiedadID",
                principalTable: "GruposPropiedades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
