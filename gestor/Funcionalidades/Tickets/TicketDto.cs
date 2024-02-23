using src;

namespace gestor.Funcionalidades.Tickets
{
    public class TicketDto
    {
        public required int IdTicket { get; set; }
        public required string Descripcion { get; set; }
        public required Estado Estado { get; set; }
        public required DateOnly Inicio { get; set; }
        public required DateOnly Fin { get; set; }
        public required int IdUsuario { get; set; }
        public required int IdProyecto { get; set; }
    }
}