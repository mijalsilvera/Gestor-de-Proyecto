using Microsoft.AspNetCore.Mvc;
namespace gestor.Funcionalidades.Usuarios;

public static class UsuarioEndpoints
{
    public static void MapUsuarioEndpoint(this WebApplication app)
    {
        app.MapGet("/api/Usuario", ([FromServices] IUsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetUsuarios());
        });
    }

}
