using src;

namespace gestor.Funcionalidades.ProyectoF;


public interface IProyectoService
{
    List<Proyecto> GetProyectos();
}
public class ProyectoService : IProyectoService
{
    List<Proyecto> proyectos;
    public ProyectoService()
    {
        proyectos = new List<Proyecto>()
        {
            new Proyecto(1, "nayeli", "en proceso"),
        };
    }
    public List<Proyecto> GetProyectos()
    {
        return proyectos;
    }

}

