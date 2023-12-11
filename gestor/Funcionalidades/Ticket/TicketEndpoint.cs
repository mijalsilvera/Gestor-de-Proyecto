using Microsoft.AspNetCore.Mvc;

namespace gestor.Funcionalidades.TicketF;

public static class TicketEndpoint
{
    public static void MapTicketEndpoint(this WebApplication app)
    {
        app.MapGet("/gestor/Ticket", ([FromServices]ITicketService ticketService) =>
        {
            return Results.Ok(ticketService.GetTickets());
        });
    }
}
