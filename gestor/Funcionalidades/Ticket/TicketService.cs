
namespace gestor.Funcionalidades.Ticket;


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
            new Ticket(new Guid(), "ticket1", 1, 06-04-2022, 07-12-2023, "hola", "mijal"),
        }
    }


    public List<Ticket> GetTickets()
    {
        throw new NotImplementedException();
    }
}
