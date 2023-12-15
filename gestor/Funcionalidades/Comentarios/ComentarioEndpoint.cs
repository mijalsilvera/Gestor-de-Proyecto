using Carter;
using Microsoft.AspNetCore.Mvc;
using src;

namespace gestor.Funcionalidades.Comentarios;

public class ComentarioEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Comentario", ([FromServices] IComentarioService comentarioService) =>
        {
            return Results.Ok(comentarioService.GetComentarios());
        });

        app.MapPost("/api/song", ([FromServices] IComentarioService comentarioService, ComentarioDto comentarioDto) =>
        {
            comentarioService.CreateComentario(comentarioDto);
            return Results.Ok();
        });

        app.MapPut("/api/song/{comentarioId}", ([FromServices] IComentarioService comentarioService, int comentarioId, ComentarioDto comentarioDto) =>
        {

            comentarioService.UpdateComentario(comentarioId, comentarioDto);
            return Results.Ok();
        });

        app.MapPut("/api/song/{comentarioId}", ([FromServices] IComentarioService comentarioService, ComentarioDto comentarioDto) =>
        {

            comentarioService.Delete(comentarioId, comentarioDto);
            return Results.Ok();
        });
    }
}
