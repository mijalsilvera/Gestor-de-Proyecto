using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestor.Funcionalidades.Proyectos
{
    public class ProyectoDto
    {
        public required int IdProyecto { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        
    }
}