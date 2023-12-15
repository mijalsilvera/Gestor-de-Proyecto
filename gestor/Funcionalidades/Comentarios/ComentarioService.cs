using gestor;
using gestor.Persistencia;
using src;

namespace gestor.Funcionalidades.Comentarios;

public interface IComentarioService
{
    void CreateComentario(ComentarioDto comentarioDto);
    void Delete(object comentarioId, ComentarioDto comentarioDto);
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
        context.Comentarios.Add(new Comentario(comentarioDto.comentarioId, comentarioDto.mensaje, comentarioDto.FechaHora, comentarioDto.IdUsuario, comentarioDto.IdTicket));
        context.SaveChanges();
    }

    public void Delete(object comentarioId, ComentarioDto comentarioDto)
    {
        throw new NotImplementedException();
    }

    public List<Comentario> GetComentarios()
    {
        return context.Comentarios.ToList();
    }

    public void UpdateComentario(int comentarioId, ComentarioDto comentarioDto)
    {
        var comentario = context.Comentarios.FirstOrDefault(x => x.comentarioId == comentarioId);

        comentario.comentarioId = comentarioDto.comentarioId;
        comentario.Mensaje = comentarioDto.mensaje;
        comentario.FechaHora = comentarioDto.FechaHora;
        comentario.IdUsuario = comentarioDto.IdUsuario;
        comentario.IdTicket = comentarioDto.IdTicket;
        context.SaveChanges();
    }
}