using Microsoft.EntityFrameworkCore.Migrations;

namespace Unicorp.App.Persistencia.Migrations
{
    public partial class Inicial01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Pago = table.Column<int>(type: "int", nullable: false),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    Tarifa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soporte_pago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entidad_bancaria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_completo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_registro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Membresia = table.Column<bool>(type: "bit", nullable: true),
                    Tipo_cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Formacion_profesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarjeta_profesional = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ID_Tecnico = table.Column<int>(type: "int", nullable: false),
                    Tarifa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pago");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Servicio");
        }
    }
}
