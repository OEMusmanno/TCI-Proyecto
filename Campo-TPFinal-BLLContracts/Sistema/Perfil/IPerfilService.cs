using Campo_TPFinal_BE.Sistema.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.Sistema.Perfil
{
    public interface IPerfilService
    {
        void addRol(Rol rol);
        List<Familia> GetFamilias();
        List<Rol> getRoles();
        Rol getRolForUser(int rolId);
        void borrarPerfil(Rol selectedItem);
    }
}
