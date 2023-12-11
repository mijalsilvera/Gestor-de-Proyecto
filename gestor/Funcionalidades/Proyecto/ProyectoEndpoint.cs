using Microsoft.AspNetCore.Mvc;

namespace gestor.Funcionalidades.ProyectoF;

public static class ProyectoEndpoint
{
    public static void MapProyectoEndpoint(this WebApplication app)
    {
        app.MapGet("/gestor/Ticket", ([FromServices]IProyectoService proyectoService) =>
        {
            return Results.Ok(proyectoService.GetProyectos());
        });
    }
}
