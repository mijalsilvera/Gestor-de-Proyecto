using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestor.Funcionalidades.Usuarios
{
    public class UsuarioDto
    {
        public required int IdUsuario { get; set; }
        public required string Nombre { get; set; }
        public required string Email { get; set; }
        public required string Contrasena { get; set; }
        public required string IdComentario { get; set; }

    }
}