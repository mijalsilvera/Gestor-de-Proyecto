using Microsoft.EntityFrameworkCore;
using src;

namespace gestor.Persistencia;

public class AplicacionDbContext : DbContext
{
    public AplicacionDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Comentario> Comentarios { get; set; }
    public DbSet<Usuario> Usuariossuarios { get; set; }
    public DbSet<Proyecto> Proyectos { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}
