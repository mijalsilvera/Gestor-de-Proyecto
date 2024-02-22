using gestor;
using gestor.Persistencia;
using src;

namespace gestor.Funcionalidades.Comentarios;

public interface IComentarioService
{
    void CreateComentario(ComentarioDto comentarioDto);
    void DeleteComentario(int Idcomentario);
    List<Comentario> GetComentarios();
    void UpdateComentario(int Idcomentario, ComentarioDto comentarioDto);
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
        context.Comentarios.Add(new Comentario(comentarioDto.IdComentario, comentarioDto.Mensaje, comentarioDto.FechaHora, comentarioDto.IdUsuario, comentarioDto.IdTicket));
        context.SaveChanges();
    }

    public void DeleteComentario(int IdComentario)
    {
        var comentario = context.Comentarios.FirstOrDefault(x => x.IdComentario == IdComentario);

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

    public void UpdateComentario(int IdComentario, ComentarioDto comentarioDto)
    {
        var comentario = context.Comentarios.FirstOrDefault(x => x.IdComentario == IdComentario);

        if (comentario != null)
        {
            comentario.IdComentario = comentarioDto.IdComentario;
            comentario.Mensaje = comentarioDto.Mensaje;
            comentario.FechaHora = comentarioDto.FechaHora;
            comentario.Usuario = comentarioDto.IdUsuario;
            comentario.IdTicket = comentarioDto.IdTicket;
            context.SaveChanges();
        }

    }
}