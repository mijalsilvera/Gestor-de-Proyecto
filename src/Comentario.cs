namespace src;

public class Comentario
{
    public string Descripcion { get; set; }
    public DateTime FechaHora { get; set; }
    public Usuario Usuario { get; set; }
    public Ticket Ticket { get; set; }

    public Comentario(string descripcion, DateTime fecharHora, Usuario usuario, Ticket ticket)
    {
        Descripcion = descripcion;
        FechaHora = fecharHora;
        Usuario = usuario;
        Ticket = ticket;
    }
}
