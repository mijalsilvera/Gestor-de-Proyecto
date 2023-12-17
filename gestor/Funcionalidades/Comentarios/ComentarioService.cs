using gestor;
using gestor.Persistencia;
using src;

namespace gestor.Funcionalidades.Comentarios;

public interface IComentarioService
{
    void CreateComentario(ComentarioDto comentarioDto);
    void DeleteComentario(int comentarioId);
    List<Comentario> GetComentarios();
    void UpdateComentario(int comentarioId, ComentarioDto comentarioDto);
}

public class ComentarioService : IComentarioService
{
    private readonly AplicacionDbContext context;

    public ComentarioService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void CreateComentario(ComentarioDto comentarioDto)
    {
        context.Comentarios.Add(new Comentario(comentarioDto.ComentarioId, comentarioDto.Mensaje, comentarioDto.FechaHora, comentarioDto.IdUsuario, comentarioDto.IdTicket));
        context.SaveChanges();
    }

    public void DeleteComentario(int comentarioId)
    {
        var comentario = context.Comentarios.FirstOrDefault(x => x.ComentarioId == comentarioId);
        
        if (comentario != null)
        {
            context.Comentarios.Remove(comentario);
            context.SaveChanges();
        } 
    }

    public List<Comentario> GetComentarios()
    {
        return context.Comentarios.ToList();
    }

    public void UpdateComentario(int comentarioId, ComentarioDto comentarioDto)
    {
        var comentario = context.Comentarios.FirstOrDefault(x => x.ComentarioId == comentarioId);

        if (comentario != null)
        {
            comentario.ComentarioId = comentarioDto.ComentarioId;
            comentario.Mensaje = comentarioDto.Mensaje;
            comentario.FechaHora = comentarioDto.FechaHora;
            comentario.IdUsuario = comentarioDto.IdUsuario;
            comentario.IdTicket = comentarioDto.IdTicket;
            context.SaveChanges();
        }
        
    }
}