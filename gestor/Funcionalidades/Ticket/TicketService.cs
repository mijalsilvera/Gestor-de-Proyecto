
using src;

namespace gestor.Funcionalidades.TicketF;


public interface ITicketService
{
    List<Ticket> GetTickets();
}
public class TicketService : ITicketService
{
    List<Ticket> tickets;
    public TicketService()
    {
        tickets = new List<Ticket>()
        {
            new Ticket(1, "ticket1", Estado.abierto, new DateOnly(2022, 06, 06), new DateOnly(2023, 12, 17)),
            new Ticket(2, "ticket2", Estado.abierto, new DateOnly(2022, 06, 22), new DateOnly(2023, 11, 04)),
        };
    }

    public List<Ticket> GetTickets()
    {
        return tickets;
    }


}