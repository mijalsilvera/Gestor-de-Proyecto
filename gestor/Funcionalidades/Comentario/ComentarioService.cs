using src;

namespace gestor.Funcionalidades.ComentarioF;

public interface IComentarioService
{
    List<Comentario> GetComentarios();
}

public class ComentarioService : IComentarioService
{
    List<Comentario> comentarios;

    public ComentarioService()
    {
        comentarios = new List<Comentario>()
        {
            new Comentario("Grandioso", DateTime.Now , 2, 1),
            new Comentario("Malisimo", DateTime.Now , 2, 2),

        };
    }

    public List<Comentario> GetComentarios()
    {
        return comentarios;
    }
}
