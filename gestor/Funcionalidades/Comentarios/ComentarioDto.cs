namespace gestor.Funcionalidades.Comentarios;

public class ComentarioDto
{
    public required int comentarioId { get; set; }
    public required string mensaje { get; set; }
    public required DateTime FechaHora { get; set; }
    public required int IdUsuario { get; set; }
    public required int IdTicket { get; set; }
}
