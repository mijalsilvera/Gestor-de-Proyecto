using Carter;
using Microsoft.AspNetCore.Mvc;
namespace gestor.Funcionalidades.Tickets;

public class TicketEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Ticket", ([FromServices] ITicketService ticketService) =>
        {
            return Results.Ok(ticketService.GetTickets());
        });
    }
}
