using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src;
[Table("ticket")]

public class Ticket
{
    [Key]
    [Required]

    public int IdTicket { get; set; }
    [Required]
    [StringLength(50)]
    public string Descripcion { get; set; }
    [Required]
    public Estado Estado { get; set; }
    public DateOnly Inicio { get; set; }
    public DateOnly Fin { get; set; }
    public List<Comentario> Actividades { get; set; }
    public Proyecto Proyecto { get; set; }
    public int Usuario { get; set; }



    public Ticket(int idTicket, string descripcion, Estado estado, DateOnly inicio, DateOnly fin, int usuario)
    {
        IdTicket = idTicket;
        Descripcion = descripcion;
        Estado = estado;
        Inicio = inicio;
        Fin = fin;
        Usuario = usuario;
        Actividades = new List<Comentario>();
    }

    public void Modificar(string nuevaDescripcion)
    {
        this.Descripcion = nuevaDescripcion;
    }

    public Ticket(int v)
    {

    }
}

