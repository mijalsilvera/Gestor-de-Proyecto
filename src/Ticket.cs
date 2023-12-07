namespace src;

public class Ticket
{
    public Guid IdTicket { get; set; }
    public string Descripcion { get; set;}
    public Estado Estado { get; set; }
    public DateOnly  Inicio { get; set; }
    public DateOnly Fin { get; set; }
    public List<Comentario> Actividades { get; set; }
    public List<Usuario> Usuarios { get; set; } 

    public Ticket (Guid idTicket, string descripcion, Estado estado,  DateOnly inicio, DateOnly fin)
    {   
        IdTicket = idTicket;
        Descripcion = descripcion;
        Estado = estado;
        Inicio = inicio;
        Fin = fin;
        Actividades = new List<Comentario>();
        Usuarios = new List<Usuario>();
    }
    
    public void Modificar(string nuevaDescripcion)
    {
        this.Descripcion = nuevaDescripcion;
    }


}

