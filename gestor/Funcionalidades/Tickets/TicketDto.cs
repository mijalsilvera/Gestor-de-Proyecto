using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src;

namespace gestor.Funcionalidades.Tickets
{
    public class TicketDto
    {
        public required int IdTicket { get; set; }
        public required string Descripcion { get; set; }
        public required Estado Estado { get; set; }
        public required DateOnly Inico { get; set; }
        public required DateOnly Fin { get; set; }

    }
}