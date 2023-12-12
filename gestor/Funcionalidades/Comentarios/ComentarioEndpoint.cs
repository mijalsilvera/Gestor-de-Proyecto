using Microsoft.AspNetCore.Mvc;
namespace gestor.Funcionalidades.Comentarios;

public static class ComentarioEndpoint
{
    public static void MapComentarioEndpoint(this WebApplication app)
    {
        app.MapGet("/api/Comentario", ([FromServices] IComentarioService comentarioService) =>
        {
            return Results.Ok(comentarioService.GetComentarios());
        });
    }
}
