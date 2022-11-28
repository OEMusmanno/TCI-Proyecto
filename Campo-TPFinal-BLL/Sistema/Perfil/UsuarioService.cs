using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLL.Sistema.Serializacion;
using Campo_TPFinal_BLLContracts.Sistema;
using Campo_TPFinal_BLLContracts.Sistema.Perfil;
using Campo_TPFinal_DALContracts;

namespace Campo_TPFinal_BLL.Sistema.Perfil
{
    public  class UsuarioService: IUsuarioService
    {
        readonly IUsuarioRepository usuarioRepository;
        readonly IDigitoVerificadorService digitoVerificadorService;
        readonly IBackupService backupService;

        public UsuarioService(IUsuarioRepository usuarioRepository, IDigitoVerificadorService digitoVerificadorService, IBackupService backupService)
        {
            this.usuarioRepository = usuarioRepository;
            this.digitoVerificadorService = digitoVerificadorService;
            this.backupService = backupService;         
        }

        public void AgregarUsuario(Usuario user)
        {
            usuarioRepository.AgregarUsuario(user);
            digitoVerificadorService.CalcularDigitoVerificador();
        }

        public void BorrarUsuario(int userId)
        {
            usuarioRepository.BorrarUsuario(userId);
            digitoVerificadorService.CalcularDigitoVerificador(); 
        }

        public void ActualizarUsuario(Usuario user)
        {
            usuarioRepository.ActualizarUsuario(user);
            digitoVerificadorService.CalcularDigitoVerificador();
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
            digitoVerificadorService.CalcularDigitoVerificador();
        }

        public Usuario ObtenerPorId( int id)
        {
            return usuarioRepository.ObtenerPorId(id);            
        }       
    }
}
