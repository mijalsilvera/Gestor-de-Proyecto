using Microsoft.AspNetCore.Mvc;
namespace gestor.Funcionalidades.Tickets;

public static class TicketEndpoint
{
    public static void MapTicketEndpoint(this WebApplication app)
    {
        app.MapGet("/api/Ticket", ([FromServices] ITicketService ticketService) =>
        {
            return Results.Ok(ticketService.GetTickets());
        });
    }
}
