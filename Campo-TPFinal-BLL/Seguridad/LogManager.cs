using Campo_TPFinal_BLLContracts;
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
        private readonly IUsuarioRepository usuarioRepository;

        private readonly IBitacoraService bitacoraService;
        public LogManager(IUsuarioRepository usuarioRepository, IBitacoraService bitacoraService)
        {
            this.usuarioRepository = usuarioRepository;
            this.bitacoraService = bitacoraService;
        }

        public bool log(string name, string pass, int intentos)
        {
            var sesion = Session.GetInstance();
            if (name == "" || pass == "") { throw new Exception("Debe Ingresar todos los campos"); }
            if (intentos == 3)
            {
                throw new Exception("Se realizaron muchos intentos. Se cerrara el sistema");
                bitacoraService.GuardarBitacoraDefault("El usuario: " + name + " ingreso 3 veces mal la contraseña");
            }

            var bdUser = usuarioRepository.ObtenerPorAlias(name);
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
