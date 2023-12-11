
using Microsoft.AspNetCore.Mvc;

namespace gestor.Funcionalidades.ComentarioF;

public static class ComentarioEndpoint
{
    public static void MapComentarioEndpoint(this WebApplication app)
    {
        app.MapGet("/gestor/Ticket", ([FromServices]IComentarioService comentarioService) =>
        {
            return Results.Ok(comentarioService.GetComentarios());
        });
    }
}
