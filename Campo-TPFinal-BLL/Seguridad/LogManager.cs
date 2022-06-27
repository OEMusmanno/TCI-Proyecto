using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Perfil;
using Campo_TPFinal_DALContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Seguridad
{
    public class LogManager
    {
        private readonly IUsuarioService usuarioService;

        private readonly IBitacoraService bitacoraService;
        public LogManager(IUsuarioService usuarioService, IBitacoraService bitacoraService)
        {
            this.usuarioService = usuarioService;
            this.bitacoraService = bitacoraService;
        }

        public bool log(string name, string pass, int intentos)
        {
            var sesion = Session.GetInstance();
            if (name == "" || pass == "") { throw new Exception("Debe Ingresar todos los campos"); }
            var bdUser = usuarioService.ObtenerPorAlias(name);

            if (bdUser == null) { throw new Exception("No existe el usuario"); }
            if (bdUser.bloqueado) { throw new Exception("el usuario se encuentra bloqueado"); }

            if (intentos == 3)
            {
                throw new Exception("Se realizaron muchos intentos. Se bloqueo el usuario. Se cerrara el sistema");
                usuarioService.bloquear(bdUser.Id);
                bitacoraService.GuardarBitacoraDefault("El usuario: " + name + " ingreso 3 veces mal la contraseña");
                bitacoraService.GuardarBitacoraDefault("El usuario: " + name + " ha sido bloqueado");
            }

            if (bdUser != null ? bdUser.password == CryptographyHelper.encrypt(pass) : false)
            {
                sesion.usuario = bdUser;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
