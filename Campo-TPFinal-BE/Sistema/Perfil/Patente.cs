using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Sistema.Perfil
{
    public class Patente : Rol
    {
        public override IList<Rol> Hijos
        {
            get
            {
                return new List<Rol>();
            }

        }

        public override bool tienePermiso(string permiso)
        {
            return permiso == this.name;
        }
    }
}
