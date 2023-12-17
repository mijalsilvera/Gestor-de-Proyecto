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

        app.MapPost("/api/usuario", ([FromServices] IUsuarioService usuarioService, UsuarioDto usuarioDto) =>
        {
            usuarioService.CreateUsuario(usuarioDto);
            return Results.Ok();
        });

        app.MapPut("/api/usuario/IdUsuario", ([FromServices] IUsuarioService usuarioService, int IdUsuario, UsuarioDto usuarioDto) =>
        {
            usuarioService.UpdateUsuario(IdUsuario, usuarioDto);
            return Results.Ok();
        });

        app.MapDelete("/api/usuario/IdUsuario", ([FromServices] IUsuarioService usuarioService, int IdUsuario) =>
        {
            usuarioService.DeleteUsuario(IdUsuario);
            return Results.Ok();
        });
    }
}
