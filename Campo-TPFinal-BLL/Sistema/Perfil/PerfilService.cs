using Campo_TPFinal_BE.Sistema.Perfil;
using Campo_TPFinal_BLLContracts.Sistema.Perfil;
using Campo_TPFinal_DALContracts.Sistema.Perfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Sistema.Perfil
{
    public class PerfilService: IPerfilService
    {
        readonly IPerfilRepository perfilRepository;

        public PerfilService(IPerfilRepository perfilRepository)
        {
            this.perfilRepository = perfilRepository;
        }
        public void addRol(Rol rol)
        {
            perfilRepository.AddRol(rol);
        }

        public Rol getRolForUser(int rolId)
        {
            return perfilRepository.getAllFamiliaPorId(rolId);
        }
        public List<Rol> getRoles()
        {
            return perfilRepository.getAllRoles();
        }
        public List<Familia> GetFamilias()
        {
            return perfilRepository.getAllFamilia();
        }

        public void borrarPerfil(Rol selectedItem)
        {
            perfilRepository.DeleteRol(selectedItem);
        }
    }
}
