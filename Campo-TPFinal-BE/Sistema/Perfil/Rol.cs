using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Sistema.Perfil
{
    public abstract class Rol
    {

        public string name { get; set; }
        public int id { get; set; }

        public abstract IList<Rol> Hijos { get; }
        public abstract bool tienePermiso(string permiso);
        public override string ToString()
        {
            return name + " - " + this.GetType().Name;
        }
    }
}
