namespace src;

public class Usuario
{
    public int IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Contrasena { get; set; }
    public List<Ticket> Tickets { get; set; }

    public Usuario(int idUsuario, string nombre, string email, string contrasena)
    {
        IdUsuario = idUsuario;
        Nombre = nombre;
        Email = email;
        Contrasena = contrasena;
        Tickets = new List<Ticket>();
    }
    
}
