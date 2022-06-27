using Campo_TPFinal_BE.Usuario;

namespace Campo_TPFinal_BLLContracts.Sistema.Perfil
{
    public interface IUsuarioService
    {
        void ActualizarUsuario(Usuario user);
        void AgregarUsuario(Usuario user);
        void bloquear(int userId);
        void BorrarUsuario(int userId);
        void desbloquear(int userId);
        List<Usuario> Listar();
        Usuario ObtenerPorAlias(string name);
        List<Usuario> ListarBloqueados();
    }
}
