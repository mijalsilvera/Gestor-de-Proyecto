using Microsoft.EntityFrameworkCore;
using src;

namespace gestor.Persistencia;

public class AplicacionDbContext : DbContext
{
    public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options)
    {
    }

    public DbSet<Comentario> Comentarios { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Proyecto> Proyectos { get; set; }
    public DbSet<Ticket> Tickets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comentario>().HasData(
            new Comentario(1, "hola", DateTime.Now, 1, 2),
            new Comentario(2, "bye", DateTime.Now, 0, 3),
            new Comentario(3, "heladommm", DateTime.Now, 3, 1)
        );

        var proyecto1 = new Proyecto(1, "nayeli", "apruebenos");
        var proyecto2 = new Proyecto(2, "mijal", "porfavor");

        modelBuilder.Entity<Proyecto>().HasData(proyecto1, proyecto2);

        var usuario1 = new Usuario(1, "Mijal", "mijal@gmail.com", "1245", "holaMundo");
        var usuario2 = new Usuario(2, "Lucero", "lucerosilvera@gmail.com", "458", "AdiosMundo");

        modelBuilder.Entity<Usuario>().HasData(usuario1, usuario2);

        //modelBuilder.Entity<Ticket>().HasData(
        //    new Ticket(1, "Abonado", Estado.abierto, new DateOnly(2022, 07, 08), new DateOnly(2022, 05, 09), usuario1, proyecto1),
         //   new Ticket(2, "No abonado", Estado.fin, new DateOnly(2023, 02, 04), new DateOnly(2023, 06, 10), usuario2, proyecto2)
        //);
    }
}