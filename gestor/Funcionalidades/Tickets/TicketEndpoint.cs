using Carter;
using Microsoft.AspNetCore.Mvc;
using src;
namespace gestor.Funcionalidades.Tickets;

public class TicketEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/Ticket", ([FromServices] ITicketService ticketService) =>
        {
            return Results.Ok(ticketService.GetTickets());
        });

        app.MapPost("/api/ticket", ([FromServices] ITicketService ticketService, TicketDto ticketDto) =>
        {
            ticketService.CreateTicket(ticketDto);
            return Results.Ok();
        });

        app.MapPut("/api/ticket/IdTicket", ([FromServices] ITicketService ticketService, int IdTicket, TicketDto ticketDto) =>
        {
            ticketService.UpdateProyecto(IdTicket, ticketDto);
            return Results.Ok();
        });

        app.MapDelete("/api/ticket/IdTicket", ([FromServices] ITicketService ticketService, int IdTicket) =>
        {
            ticketService.DeleteTicket(IdTicket);
            return Results.Ok();
        });

    }
}
