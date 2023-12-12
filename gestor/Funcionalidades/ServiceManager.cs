namespace gestor.Funcionalidades;

    public class ServiceManager
    {
        public static IServiceCollection AddServiceManager(this IServiceCollection services)
        {
          services.AddSingleton<IComentarioService, ComentarioService>();
          services.AddSingleton<IProyectoService, ProyectoService>();
          services.AddSingleton<ITicketService, TicketService>();
          services.AddSingleton<IUsuarioService, UsuarioService>();  
        }
        return services;
        
    }
