using Carter;
using Microsoft.AspNetCore.Mvc;
namespace gestor.Funcionalidades.Proyectos;

public class ProyectoEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Proyecto", ([FromServices] IProyectoService proyectoService) =>
        {
            return Results.Ok(proyectoService.GetProyectos());
        });
    }
}
