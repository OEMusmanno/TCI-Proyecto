using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
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
            if (name == "" || pass == "") { throw new Exception(Session.traducciones["ErrorCampoVacio"].Texto); }
            var bdUser = usuarioService.ObtenerPorAlias(name);

            if (bdUser == null) { throw new Exception(Session.traducciones["ErrorLogin"].Texto); }
            if (bdUser.bloqueado) { throw new Exception(Session.traducciones["ErrorUsuarioBloqueado"].Texto); }

            if (intentos == 3)
            {
                usuarioService.bloquear(bdUser.Id);
                bitacoraService.GuardarBitacora("El usuario: " + name + " ingreso 3 veces mal la contraseña");
                bitacoraService.GuardarBitacora("El usuario: " + name + " ha sido bloqueado");
                throw new Exception(Session.traducciones["Error3Intento"].Texto);
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
