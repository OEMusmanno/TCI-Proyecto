using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Sistema.Perfil
{
    public class Familia :Rol
    {
        public List<Rol> patentes = new List<Rol>();

        public override IList<Rol> Hijos
        {
            get
            {
                return patentes.ToArray();
            }

        }
        public void AgregarHijo(Rol c)
        {
            Hijos.Add(c);
        }
        public override bool tienePermiso(string permiso)
        {
            foreach (var patente in patentes)
            {
                if (patente.tienePermiso(permiso) || this.name == permiso)
                {
                    return true;
                };
            }
            return false;
        }
    }
}
