using gestor;
using gestor.Persistencia;
using src;

namespace gestor.Funcionalidades.Tickets;


public interface ITicketService
{
    List<Ticket> GetTickets();
}
public class TicketService : ITicketService
{
    private readonly AplicacionDbContext context;

    public TicketService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public List<Ticket> GetTickets()
    {
        return context.Tickets.ToList();
    }


}