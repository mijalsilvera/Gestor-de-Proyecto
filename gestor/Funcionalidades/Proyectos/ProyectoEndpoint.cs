using Microsoft.AspNetCore.Mvc;
namespace gestor.Funcionalidades.Proyectos;

public static class ProyectoEndpoint
{
    public static void MapProyectoEndpoint(this WebApplication app)
    {
        app.MapGet("/api/Proyecto", ([FromServices] IProyectoService proyectoService) =>
        {
            return Results.Ok(proyectoService.GetProyectos());
        });
    }
}
