using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLenguajesNetCore.Data.Migrations
{
    public partial class Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID_CLIENTE = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOMBRE = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    APELLIDO = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    GENERO = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    CORREO = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    DIRECCION = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    TELEFONO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID_CLIENTE);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
