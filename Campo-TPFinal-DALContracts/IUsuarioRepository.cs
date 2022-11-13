using Campo_TPFinal_BE.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts
{
    public interface IUsuarioRepository
    {
        public Usuario ObtenerPorAlias(string alias);
        List<Usuario> Listar();
     
        void ActualizarUsuario(Usuario user);
        void AgregarUsuario(Usuario user);
        void ActualizarDvh(int idUsuario , string dvh );
        void BorrarUsuario(int userId);
        void bloquear(int userId);
        void desbloquear(int userId);
        List<Usuario> ListarBloqueados();
        Usuario ObtenerPorId(int Id);
        List<string> ListarDvh();
    }
}
