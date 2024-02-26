using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src;
[Table("comentario")]

public class Comentario
{
    [Key]
    [Required]
    public int IdComentario { get; set; }
    [Required]
    public string Mensaje { get; set; }
    [Required]
    public DateTime FechaHora { get; set; }
    [Required]
    public int Usuario { get; set; }
    [Required]
    [StringLength(50)]
    public int IdTicket { get; set; }

    public Comentario(int idComentario, string mensaje, DateTime fechaHora, int usuario, int idTicket)
    {
        IdComentario = idComentario;
        Mensaje = mensaje;
        FechaHora = fechaHora;
        Usuario = usuario;
        IdTicket = idTicket;
        
    }

    public Comentario()
    {

    }
}
