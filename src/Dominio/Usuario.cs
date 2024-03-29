﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Versioning;

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
    public string IdComentario { get; set; }
    public List<Proyecto> Proyectos { get; set; }
    public List<Ticket> Tickets { get; set; }
    public List<Comentario> Comentarios { get; set; }

    public Usuario(int idUsuario, string nombre, string email, string contrasena, string idComentario)
    {
        IdUsuario = idUsuario;
        Nombre = nombre;
        Email = email;
        Contrasena = contrasena;
        IdComentario = idComentario;
        Tickets = new List<Ticket>();
        Proyectos = new List<Proyecto>();
        Comentarios = new List<Comentario>();
    }

    public Usuario()
    {

    }
}
