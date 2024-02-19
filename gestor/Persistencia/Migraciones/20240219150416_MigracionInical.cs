using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gestor.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class MigracionInical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proyecto",
                columns: table => new
                {
                    IdProyecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proyecto", x => x.IdProyecto);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contrasena = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comentarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.IdUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProyectoUsuario",
                columns: table => new
                {
                    ProyectosIdProyecto = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoUsuario", x => new { x.ProyectosIdProyecto, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_ProyectoUsuario_proyecto_ProyectosIdProyecto",
                        column: x => x.ProyectosIdProyecto,
                        principalTable: "proyecto",
                        principalColumn: "IdProyecto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoUsuario_usuario_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    IdTicket = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Inicio = table.Column<DateOnly>(type: "date", nullable: false),
                    Fin = table.Column<DateOnly>(type: "date", nullable: false),
                    IdUsuarioUsuario = table.Column<int>(type: "int", nullable: false),
                    ProyectoIdProyecto = table.Column<int>(type: "int", nullable: true),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.IdTicket);
                    table.ForeignKey(
                        name: "FK_ticket_proyecto_ProyectoIdProyecto",
                        column: x => x.ProyectoIdProyecto,
                        principalTable: "proyecto",
                        principalColumn: "IdProyecto");
                    table.ForeignKey(
                        name: "FK_ticket_usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "usuario",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "comentario",
                columns: table => new
                {
                    ComentarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mensaje = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdTicket = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    TicketIdTicket = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comentario", x => x.ComentarioId);
                    table.ForeignKey(
                        name: "FK_comentario_ticket_TicketIdTicket",
                        column: x => x.TicketIdTicket,
                        principalTable: "ticket",
                        principalColumn: "IdTicket");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "comentario",
                columns: new[] { "ComentarioId", "FechaHora", "IdTicket", "IdUsuario", "Mensaje", "TicketIdTicket" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 19, 12, 4, 16, 726, DateTimeKind.Local).AddTicks(7596), 2, 1, "hola", null },
                    { 2, new DateTime(2024, 2, 19, 12, 4, 16, 726, DateTimeKind.Local).AddTicks(7610), 3, 2, "bye", null },
                    { 3, new DateTime(2024, 2, 19, 12, 4, 16, 726, DateTimeKind.Local).AddTicks(7611), 1, 3, "heladommm", null }
                });

            migrationBuilder.InsertData(
                table: "proyecto",
                columns: new[] { "IdProyecto", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "apruebenos", "nayeli" },
                    { 2, "porfavor", "mijal" }
                });

            migrationBuilder.InsertData(
                table: "ticket",
                columns: new[] { "IdTicket", "Descripcion", "Estado", "Fin", "IdUsuarioUsuario", "Inicio", "ProyectoIdProyecto", "UsuarioIdUsuario" },
                values: new object[,]
                {
                    { 1, "Abonado", 1, new DateOnly(2022, 5, 9), 0, new DateOnly(2022, 7, 8), null, null },
                    { 2, "No abonado", 4, new DateOnly(2023, 6, 10), 0, new DateOnly(2023, 2, 4), null, null }
                });

            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "IdUsuario", "Contrasena", "Email", "Nombre", "comentarioId" },
                values: new object[,]
                {
                    { 1, "1245", "mijal@gmail.com", "Mijal", 0 },
                    { 2, "458", "lucerosilvera@gmail.com", "Lucero", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_comentario_TicketIdTicket",
                table: "comentario",
                column: "TicketIdTicket");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoUsuario_UsuariosIdUsuario",
                table: "ProyectoUsuario",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_ProyectoIdProyecto",
                table: "ticket",
                column: "ProyectoIdProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_UsuarioIdUsuario",
                table: "ticket",
                column: "UsuarioIdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comentario");

            migrationBuilder.DropTable(
                name: "ProyectoUsuario");

            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "proyecto");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
