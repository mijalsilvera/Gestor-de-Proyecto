using gestor;
using gestor.Persistencia;
using src;

namespace gestor.Funcionalidades.Proyectos;


public interface IProyectoService
{
    List<Proyecto> GetProyectos();
}
public class ProyectoService : IProyectoService
{
    private readonly AplicacionDbContext context;

    public ProyectoService(AplicacionDbContext context)
    {
        this.context = context;
    }
    public List<Proyecto> GetProyectos()
    {
        return context.Proyectos.ToList();
    }

}

