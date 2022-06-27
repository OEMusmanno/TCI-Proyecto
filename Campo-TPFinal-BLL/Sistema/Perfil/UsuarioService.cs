using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLLContracts.Sistema.Perfil;
using Campo_TPFinal_DALContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Sistema.Perfil
{
    public  class UsuarioService: IUsuarioService
    {
        readonly IUsuarioRepository usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public void AgregarUsuario(Usuario user)
        {
            usuarioRepository.AgregarUsuario(user);
        }

        public void BorrarUsuario(int userId)
        {
            usuarioRepository.BorrarUsuario(userId);
        }

        public void ActualizarUsuario(Usuario user)
        {
            usuarioRepository.ActualizarUsuario(user);
        }

        public void desbloquear(int userId)
        {
            usuarioRepository.desbloquear(userId);
        } 
        
        public void bloquear(int userId)
        {
            usuarioRepository.bloquear(userId);
        }

        public List<Usuario> Listar()
        {
            return usuarioRepository.Listar();
        }

        public List<Usuario> ListarBloqueados()
        {
            return usuarioRepository.ListarBloqueados();
        }

        public Usuario ObtenerPorAlias(string name)
        {
            return usuarioRepository.ObtenerPorAlias(name);
        }
    }
}
