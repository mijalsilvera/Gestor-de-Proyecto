using gestor;
using gestor.Persistencia;
using src;

namespace gestor.Funcionalidades.Proyectos;


public interface IProyectoService
{
    void CreateProyecto(ProyectoDto proyectoDto);
    List<Proyecto> GetProyectos();
    void UpdateProyecto(int IdProyecto, ProyectoDto proyectoDto);
}
public class ProyectoService : IProyectoService
{
    private readonly AplicacionDbContext context;

    public ProyectoService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void CreateProyecto(ProyectoDto proyectoDto)
    {
        context.Proyectos.Add(new Proyecto(proyectoDto.IdProyecto, proyectoDto.Nombre, proyectoDto.Descripcion));
        context.SaveChanges();
    }

    public List<Proyecto> GetProyectos()
    {
        return context.Proyectos.ToList();
    }

    public void UpdateProyecto(int IdProyecto, ProyectoDto proyectoDto)
    {
        var proyecto = context.Proyectos.FirstOrDefault(x => x.IdProyecto == IdProyecto);

        if (proyecto != null)
        {
            proyecto.IdProyecto = proyectoDto.IdProyecto;
            proyecto.Nombre = proyectoDto.Nombre;
            proyecto.Descripcion = proyectoDto.Descripcion;
            context.SaveChanges();
        }  
    }
}

