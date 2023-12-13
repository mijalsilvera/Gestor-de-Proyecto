using Carter;
using Microsoft.AspNetCore.Mvc;
namespace gestor.Funcionalidades.Usuarios;

public class UsuarioEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Usuario", ([FromServices] IUsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetUsuarios());
        });
    }
}
