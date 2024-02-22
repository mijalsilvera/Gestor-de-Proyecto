namespace gestor.Funcionalidades.Comentarios;

public class ComentarioDto
{
    public required int IdComentario { get; set; }
    public required string Mensaje { get; set; }
    public required DateTime FechaHora { get; set; }
    public required int IdUsuario { get; set; }
    public required int IdTicket { get; set; }
}
