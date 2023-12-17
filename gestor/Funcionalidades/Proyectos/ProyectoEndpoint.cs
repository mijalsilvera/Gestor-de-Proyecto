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

        app.MapPost("/api/proyecto", ([FromServices] IProyectoService proyectoService, ProyectoDto proyectoDto) =>
        {
            proyectoService.CreateProyecto(proyectoDto);
            return Results.Ok();
        });

        app.MapPut("/api/proyecto/IdProyecto", ([FromServices] IProyectoService proyectoService, int IdProyecto, ProyectoDto proyectoDto) =>
        {
            proyectoService.UpdateProyecto(IdProyecto, proyectoDto);
            return Results.Ok();
        });

        app.MapDelete("/api/proyecto/IdProyecto", ([FromServices] IProyectoService proyectoService, int IdProyecto) =>
        {
            proyectoService.DeleteProyecto(IdProyecto);
            return Results.Ok();
        });
        
    }
}
