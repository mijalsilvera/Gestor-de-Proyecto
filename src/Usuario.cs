namespace src;

public class Usuario
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Contrasena { get; set; }
    public List<Ticket> Tickets { get; set; }

    public Usuario(string nombre, string email, string contrasena)
    {
        Nombre = nombre;
        Email = email;
        Contrasena = contrasena;
        Tickets = new List<Ticket>();
    }

   


    
}
