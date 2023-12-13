using gestor.Funcionalidades.Comentarios;
using gestor.Funcionalidades.Proyectos;
using gestor.Funcionalidades.Tickets;
using gestor.Funcionalidades.Usuarios;

namespace gestor.Funcionalidades;

public static class ServiceManager
{
  public static IServiceCollection AddServiceManager(this IServiceCollection services)
  {
    services.AddSingleton<IComentarioService, ComentarioService>();
    services.AddSingleton<IProyectoService, ProyectoService>();
    services.AddSingleton<ITicketService, TicketService>();
    services.AddSingleton<IUsuarioService, UsuarioService>();

    return services;
  }
}
