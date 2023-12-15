using gestor.Funcionalidades.Comentarios;
using gestor.Funcionalidades.Proyectos;
using gestor.Funcionalidades.Tickets;
using gestor.Funcionalidades.Usuarios;

namespace gestor.Funcionalidades;

public static class ServiceManager
{
  public static IServiceCollection AddServiceManager(this IServiceCollection services)
  {
    services.AddScoped<IComentarioService, ComentarioService>();
    services.AddScoped<IProyectoService, ProyectoService>();
    services.AddScoped<ITicketService, TicketService>();
    services.AddScoped<IUsuarioService, UsuarioService>();

    return services;
  }
}
