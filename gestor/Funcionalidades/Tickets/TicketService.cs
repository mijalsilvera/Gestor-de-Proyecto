using gestor;
using gestor.Persistencia;
using src;

namespace gestor.Funcionalidades.Tickets;


public interface ITicketService
{
    void CreateTicket(TicketDto ticketDto);
    void DeleteTicket(int idTicket);
    List<Ticket> GetTickets();
    void UpdateProyecto(int idTicket, TicketDto ticketDto);
}
public class TicketService : ITicketService
{
    private readonly AplicacionDbContext context;

    public TicketService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void CreateTicket(TicketDto ticketDto)
    {
        context.Tickets.Add(new Ticket(ticketDto.IdTicket, ticketDto.Descripcion, ticketDto.Estado, ticketDto.Inico, ticketDto.Fin));
        context.SaveChanges();
    }

    public void DeleteTicket(int idTicket)
    {
        var ticket = context.Tickets.FirstOrDefault(x => x.IdTicket == idTicket);

        if (ticket != null)
        {
            context.Tickets.Remove(ticket);
            context.SaveChanges();
        }    
    }

    public List<Ticket> GetTickets()
    {
        return context.Tickets.ToList();
    }

    public void UpdateProyecto(int idTicket, TicketDto ticketDto)
    {
        var ticket = context.Tickets.FirstOrDefault(x => x.IdTicket == idTicket);

        if (ticket != null)
        {
            ticket.IdTicket = ticketDto.IdTicket;
            ticket.Descripcion = ticketDto.Descripcion;
            ticket.Estado = ticketDto.Estado;
            ticket.Inicio = ticketDto.Inico;
            ticket.Fin = ticketDto.Fin;
            context.SaveChanges();
        }
    }
}