using Carter;
using Microsoft.AspNetCore.Mvc;

namespace gestor.Funcionalidades.Comentarios;

public class ComentarioEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Comentario", ([FromServices] IComentarioService comentarioService) =>
        {
            return Results.Ok(comentarioService.GetComentarios());
        });
    }
}
