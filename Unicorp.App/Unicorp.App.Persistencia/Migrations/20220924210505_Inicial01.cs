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
                name: "Servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ID_Tecnico = table.Column<int>(type: "int", nullable: false),
                    Tarifa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genera_cobroId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicio_Pago_genera_cobroId",
                        column: x => x.genera_cobroId,
                        principalTable: "Pago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    TecnicosId = table.Column<int>(type: "int", nullable: true),
                    genera_pagoId = table.Column<int>(type: "int", nullable: true),
                    solicita_servicioId = table.Column<int>(type: "int", nullable: true),
                    Formacion_Academica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarjeta_Profesional = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Pago_genera_pagoId",
                        column: x => x.genera_pagoId,
                        principalTable: "Pago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_TecnicosId",
                        column: x => x.TecnicosId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Servicio_solicita_servicioId",
                        column: x => x.solicita_servicioId,
                        principalTable: "Servicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_genera_pagoId",
                table: "Persona",
                column: "genera_pagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_solicita_servicioId",
                table: "Persona",
                column: "solicita_servicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TecnicosId",
                table: "Persona",
                column: "TecnicosId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_genera_cobroId",
                table: "Servicio",
                column: "genera_cobroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Pago");
        }
    }
}
