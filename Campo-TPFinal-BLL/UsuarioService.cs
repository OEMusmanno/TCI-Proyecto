using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_DALContracts;

namespace Campo_TPFinal_BLL
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public List<Usuario> Listar()
        {
            return usuarioRepository.Listar();
        }
    }
}
