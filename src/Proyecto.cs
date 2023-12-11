using System.Data.Common;

namespace src;

public class Proyecto
{
    public int IdProyecto { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public List<Usuario> Usuarios { get; set; }
    public List<Ticket> Tickets { get; set; }
    public Proyecto(int idproyecto, string nombre, string descripcion)
    {
        IdProyecto = idproyecto;
        Nombre = nombre;
        Descripcion = descripcion;
    }
    public void Comentar(string comentario, int idUsuario, int idTicket)
    {
        var comentario1 = new Comentario(comentario, DateTime.Now, idUsuario, idTicket);
        var ticketbuscar = Tickets.FirstOrDefault(x=> x.IdTicket == idTicket);
        ticketbuscar.Actividades.Add(comentario1);
    }


}

