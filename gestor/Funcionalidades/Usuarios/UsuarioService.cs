using gestor;
using gestor.Persistencia;
using src;

namespace gestor.Funcionalidades.Usuarios;


public interface IUsuarioService
{
    void CreateUsuario(UsuarioDto usuarioDto);
    List<Usuario> GetUsuarios();
    void UpdateProyecto(int idUsuario, UsuarioDto usuarioDto);
}

public class UsuarioService : IUsuarioService
{
    private readonly AplicacionDbContext context;

    public UsuarioService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void CreateUsuario(UsuarioDto usuarioDto)
    {
        context.Usuarios.Add(new Usuario(usuarioDto.IdUsuario, usuarioDto.Nombre, usuarioDto.Email, usuarioDto.Contrasena));
        context.SaveChanges();
    }

    public List<Usuario> GetUsuarios()
    {
        return context.Usuarios.ToList();
    }

    public void UpdateProyecto(int idUsuario, UsuarioDto usuarioDto)
    {
        var usuario = context.Usuarios.FirstOrDefault(x => x.IdUsuario == idUsuario);

        if (usuario != null)
        {
            usuario.IdUsuario = usuarioDto.IdUsuario;
            usuario.Nombre = usuarioDto.Nombre;
            usuario.Email = usuarioDto.Email;
            usuario.Contrasena = usuarioDto.Contrasena;
            context.SaveChanges();
        }
    }
}

