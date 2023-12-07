using System.Data.Common;

namespace src;

public class Proyecto
{
    public Guid IdProyecto { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public List<Usuario> Usuarios { get; set; }
    public List<Ticket> Tickets { get; set; }
    public Proyecto(Guid idproyecto, string nombre, string descripcion)
    {
        IdProyecto = idproyecto;
        Nombre = nombre;
        Descripcion = descripcion;
    }
    public void Comentar(string comentario, string nombre, Guid idTicket)
    {
        var usuarioBuscar = Usuarios.FirstOrDefault(x=> x.Nombre == nombre);
        var ticketBuscar = Tickets.FirstOrDefault(x=> x.IdTicket == idTicket);
        var comentario1 = new Comentario(comentario, DateTime.Now, usuarioBuscar, ticketBuscar);
    }


}

