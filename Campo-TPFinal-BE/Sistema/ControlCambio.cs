using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Sistema
{
    public class ControlCambio
    {
        public string? id { get; set; }
        public Usuario.Usuario usuario { get; set; }
        public string? property { get; set; }
        public string? value { get; set; }
        public string? descripcion { get; set; }
        public DateTime fecha { get; set; }
    }
}
