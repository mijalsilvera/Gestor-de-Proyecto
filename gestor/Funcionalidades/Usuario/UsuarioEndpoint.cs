using Microsoft.AspNetCore.Mvc;

namespace gestor.Funcionalidades.UsuarioF;

public static class UsuarioEndpoint
{
    public static void MapUsuarioEndpoint(this WebApplication app)
    {
        app.MapGet("/gestor/Ticket", ([FromServices]IUsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetUsuarios());
        });
    }

}
