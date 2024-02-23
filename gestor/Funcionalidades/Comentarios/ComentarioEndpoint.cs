using Carter;
using Microsoft.AspNetCore.Mvc;

namespace gestor.Funcionalidades.Comentarios;

public class ComentarioEndpoint : ICarterModule
{
    public object IdComentario { get; private set; }

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

        app.MapPut("/api/song/{comentarioId}", ([FromServices] IComentarioService comentarioService, int idComentario, ComentarioDto comentarioDto) =>
        {

            comentarioService.UpdateComentario(idComentario, comentarioDto);
            return Results.Ok();
        });

        app.MapDelete("/api/song/{comentarioId}", ([FromServices] IComentarioService comentarioService, int idComentario) =>
        {

            comentarioService.DeleteComentario(idComentario);
            return Results.Ok();
        });
    }
}
