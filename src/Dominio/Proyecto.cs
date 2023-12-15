using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace src;
[Table("proyecto")]

public class Proyecto
{
    [Key]
    [Required]
    public int IdProyecto { get; set; }
    [Required]
    [StringLength(50)]
    public string Nombre { get; set; }
    [Required]
    public string Descripcion { get; set; }
    [Required]
    public List<Usuario> Usuarios { get; set; }
    public List<Ticket> Tickets { get; set; }
    public Proyecto(int idproyecto, string nombre, string descripcion)
    {
        IdProyecto = idproyecto;
        Nombre = nombre;
        Descripcion = descripcion;
    }
    public void Comentar(int comentarioId, string mensaje, int idUsuario, int idTicket)
    {
        var comentario1 = new Comentario(1, mensaje, DateTime.Now, idUsuario, idTicket);
        var ticketbuscar = Tickets.FirstOrDefault(x => x.IdTicket == idTicket);
        ticketbuscar.Actividades.Add(comentario1);
    }

    public Proyecto()
    {

    }
}

