using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class mejorasdocumentosnacionalidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentosNacionales",
                table: "DocumentosNacionales");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "DocumentosNacionales",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentosNacionales",
                table: "DocumentosNacionales",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosNacionales_ClienteID",
                table: "DocumentosNacionales",
                column: "ClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentosNacionales",
                table: "DocumentosNacionales");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosNacionales_ClienteID",
                table: "DocumentosNacionales");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "DocumentosNacionales");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentosNacionales",
                table: "DocumentosNacionales",
                columns: new[] { "ClienteID", "NacionalidadID" });
        }
    }
}
