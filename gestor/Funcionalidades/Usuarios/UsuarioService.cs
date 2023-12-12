using gestor;
using src;

namespace gestor.Funcionalidades.Usuarios;


public interface IUsuarioService
{
    List<Usuario> GetUsuarios();
}

public class UsuarioService : IUsuarioService
{
    List<Usuario> usuarios;

    public UsuarioService()
    {
        usuarios = new List<Usuario>()
        {
            new Usuario(1, "mijal", "mijal@gmail.com", "245"),      
        };
    }

    public List<Usuario> GetUsuarios()
    {
        return usuarios;
    }
}

