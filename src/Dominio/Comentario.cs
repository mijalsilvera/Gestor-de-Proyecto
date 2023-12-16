using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src;
[Table("comentario")]

public class Comentario
{
    public int idTicket;

    [Key]
    [Required]
    public int ComentarioId { get; set; }
    [Required]
    public string Mensaje { get; set; }
    [Required]
    public DateTime FechaHora { get; set; }
    [Required]
    public int IdUsuario { get; set; }
    [Required]
    [StringLength(50)]
    public int IdTicket { get; set; }

    public Comentario(int comentarioId, string mensaje, DateTime fecharHora, int idUsuario, int idTicket)
    {
        ComentarioId = comentarioId;
        Mensaje = mensaje;
        FechaHora = fecharHora;
        IdUsuario = idUsuario;
        IdTicket = idTicket;
    }

    public Comentario()
    {

    }
}
