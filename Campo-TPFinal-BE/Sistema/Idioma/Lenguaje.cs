using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Sistema.Idioma
{
    public class Lenguaje
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public bool Default { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
