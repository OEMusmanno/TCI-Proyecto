using Campo_TPFinal_BE.Sistema.Perfil;
using Campo_TPFinal_BE.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts.Sistema.Perfiles
{
    public interface IPerfilRepository
    {
        void AddRol(Rol rol);
        void DeleteRol(Rol rol);
        List<Familia> getAllFamilia();
        List<Patente> getAllPatente();
        List<Rol> getAllRoles();
        Familia getFamilia(int familiaId);
    }
}
