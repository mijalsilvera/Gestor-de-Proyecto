﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gestor.Persistencia;

#nullable disable

namespace gestor.Persistencia.Migraciones
{
    [DbContext(typeof(AplicacionDbContext))]
    [Migration("20240223031843_MigracionInicial")]
    partial class MigracionInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProyectoUsuario", b =>
                {
                    b.Property<int>("ProyectosIdProyecto")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("ProyectosIdProyecto", "UsuariosIdUsuario");

                    b.HasIndex("UsuariosIdUsuario");

                    b.ToTable("ProyectoUsuario");
                });

            modelBuilder.Entity("src.Comentario", b =>
                {
                    b.Property<int>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdTicket")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("TicketIdTicket")
                        .HasColumnType("int");

                    b.Property<int>("Usuario")
                        .HasColumnType("int");

                    b.HasKey("IdComentario");

                    b.HasIndex("TicketIdTicket");

                    b.ToTable("comentario");

                    b.HasData(
                        new
                        {
                            IdComentario = 1,
                            FechaHora = new DateTime(2024, 2, 23, 0, 18, 43, 42, DateTimeKind.Local).AddTicks(5469),
                            IdTicket = 2,
                            Mensaje = "hola",
                            Usuario = 1
                        },
                        new
                        {
                            IdComentario = 2,
                            FechaHora = new DateTime(2024, 2, 23, 0, 18, 43, 42, DateTimeKind.Local).AddTicks(5480),
                            IdTicket = 3,
                            Mensaje = "bye",
                            Usuario = 0
                        },
                        new
                        {
                            IdComentario = 3,
                            FechaHora = new DateTime(2024, 2, 23, 0, 18, 43, 42, DateTimeKind.Local).AddTicks(5481),
                            IdTicket = 1,
                            Mensaje = "heladommm",
                            Usuario = 3
                        });
                });

            modelBuilder.Entity("src.Proyecto", b =>
                {
                    b.Property<int>("IdProyecto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdProyecto");

                    b.ToTable("proyecto");

                    b.HasData(
                        new
                        {
                            IdProyecto = 1,
                            Descripcion = "apruebenos",
                            Nombre = "nayeli"
                        },
                        new
                        {
                            IdProyecto = 2,
                            Descripcion = "porfavor",
                            Nombre = "mijal"
                        });
                });

            modelBuilder.Entity("src.Ticket", b =>
                {
                    b.Property<int>("IdTicket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Fin")
                        .HasColumnType("date");

                    b.Property<DateOnly>("Inicio")
                        .HasColumnType("date");

                    b.Property<int>("ProyectoIdProyecto")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdTicket");

                    b.HasIndex("ProyectoIdProyecto");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("ticket");
                });

            modelBuilder.Entity("src.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IdComentario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdUsuario");

                    b.ToTable("usuario");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            Contrasena = "1245",
                            Email = "mijal@gmail.com",
                            IdComentario = "holaMundo",
                            Nombre = "Mijal"
                        },
                        new
                        {
                            IdUsuario = 2,
                            Contrasena = "458",
                            Email = "lucerosilvera@gmail.com",
                            IdComentario = "AdiosMundo",
                            Nombre = "Lucero"
                        });
                });

            modelBuilder.Entity("ProyectoUsuario", b =>
                {
                    b.HasOne("src.Proyecto", null)
                        .WithMany()
                        .HasForeignKey("ProyectosIdProyecto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("src.Comentario", b =>
                {
                    b.HasOne("src.Ticket", null)
                        .WithMany("Actividades")
                        .HasForeignKey("TicketIdTicket");
                });

            modelBuilder.Entity("src.Ticket", b =>
                {
                    b.HasOne("src.Proyecto", "Proyecto")
                        .WithMany("Tickets")
                        .HasForeignKey("ProyectoIdProyecto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Usuario", "Usuario")
                        .WithMany("Tickets")
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("src.Proyecto", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("src.Ticket", b =>
                {
                    b.Navigation("Actividades");
                });

            modelBuilder.Entity("src.Usuario", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}