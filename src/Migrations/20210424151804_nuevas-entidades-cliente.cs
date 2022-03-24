using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class nuevasentidadescliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Propietarios_PropietarioID",
                table: "Propiedades");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_PropietarioID",
                table: "Propiedades");

            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "Propiedades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "Prestamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "Facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Parentesco",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parentesco", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RolesClientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesClientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolClienteID = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Casado = table.Column<bool>(type: "bit", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clientes_RolesClientes_RolClienteID",
                        column: x => x.RolClienteID,
                        principalTable: "RolesClientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dependientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropietarioID = table.Column<int>(type: "int", nullable: false),
                    ParentescoID = table.Column<int>(type: "int", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Casado = table.Column<bool>(type: "bit", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClienteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependientes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dependientes_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dependientes_Parentesco_ParentescoID",
                        column: x => x.ParentescoID,
                        principalTable: "Parentesco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_ClienteID",
                table: "Propiedades",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_ClienteID",
                table: "Prestamos",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClienteID",
                table: "Facturas",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RolClienteID",
                table: "Clientes",
                column: "RolClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Dependientes_ClienteID",
                table: "Dependientes",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Dependientes_ParentescoID",
                table: "Dependientes",
                column: "ParentescoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_ClienteID",
                table: "Facturas",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Clientes_ClienteID",
                table: "Prestamos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Clientes_ClienteID",
                table: "Propiedades",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_ClienteID",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Clientes_ClienteID",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Propiedades_Clientes_ClienteID",
                table: "Propiedades");

            migrationBuilder.DropTable(
                name: "Dependientes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Parentesco");

            migrationBuilder.DropTable(
                name: "RolesClientes");

            migrationBuilder.DropIndex(
                name: "IX_Propiedades_ClienteID",
                table: "Propiedades");

            migrationBuilder.DropIndex(
                name: "IX_Prestamos_ClienteID",
                table: "Prestamos");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_ClienteID",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Propiedades");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Facturas");

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Casado = table.Column<bool>(type: "bit", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_PropietarioID",
                table: "Propiedades",
                column: "PropietarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Propiedades_Propietarios_PropietarioID",
                table: "Propiedades",
                column: "PropietarioID",
                principalTable: "Propietarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
