using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src;
[Table("usuario")]

public class Usuario
{
    [Key]
    [Required]
    public int IdUsuario { get; set; }
    [Required]
    [StringLength(50)]
    public string Nombre { get; set; }
    [Required]
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

    public Usuario()
    {

    }
}
