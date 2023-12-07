namespace gestor.Funcionalidades.Ticket;

public static class TicketEndpoint
{
    public static void AddTicketEndpoint(this WebApplication app)
    {
        app.MapGet("/gestor/Ticket", (TicketService ticketService) =>
        {
            return Results.Ok(ticketService.GetTicket());
        })
    }
}
