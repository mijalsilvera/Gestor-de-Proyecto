using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gestor.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
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
                    IdComentario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    ProyectoIdProyecto = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.IdTicket);
                    table.ForeignKey(
                        name: "FK_ticket_proyecto_ProyectoIdProyecto",
                        column: x => x.ProyectoIdProyecto,
                        principalTable: "proyecto",
                        principalColumn: "IdProyecto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "comentario",
                columns: table => new
                {
                    IdComentario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mensaje = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false),
                    IdTicket = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    TicketIdTicket = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comentario", x => x.IdComentario);
                    table.ForeignKey(
                        name: "FK_comentario_ticket_TicketIdTicket",
                        column: x => x.TicketIdTicket,
                        principalTable: "ticket",
                        principalColumn: "IdTicket");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "comentario",
                columns: new[] { "IdComentario", "FechaHora", "IdTicket", "Mensaje", "TicketIdTicket", "Usuario" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 23, 0, 18, 43, 42, DateTimeKind.Local).AddTicks(5469), 2, "hola", null, 1 },
                    { 2, new DateTime(2024, 2, 23, 0, 18, 43, 42, DateTimeKind.Local).AddTicks(5480), 3, "bye", null, 0 },
                    { 3, new DateTime(2024, 2, 23, 0, 18, 43, 42, DateTimeKind.Local).AddTicks(5481), 1, "heladommm", null, 3 }
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
                table: "usuario",
                columns: new[] { "IdUsuario", "Contrasena", "Email", "IdComentario", "Nombre" },
                values: new object[,]
                {
                    { 1, "1245", "mijal@gmail.com", "holaMundo", "Mijal" },
                    { 2, "458", "lucerosilvera@gmail.com", "AdiosMundo", "Lucero" }
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
