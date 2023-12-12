namespace src;

public class Comentario
{
    public string Mensaje { get; set; }
    public DateTime FechaHora { get; set; }
    public int  IdUsuario { get; set; }
    public int IdTicket { get; set; }

    public Comentario(string mensaje, DateTime fecharHora, int idUsuario, int idTicket)
    {
        Mensaje = mensaje;
        FechaHora = fecharHora;
        IdUsuario = idUsuario;
        IdTicket = idTicket;
    }
}
