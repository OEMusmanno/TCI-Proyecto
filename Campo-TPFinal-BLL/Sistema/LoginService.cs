using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Sistema
{
    public class LoginService: ILoginService
    {
        private readonly LogManager logManager;
        private readonly IBitacoraService bitacoraService;
        int intentos = 0;

        public LoginService(LogManager logManager, IBitacoraService bitacoraService)
        {
            this.logManager = logManager;
            this.bitacoraService = bitacoraService;
        }

        public void Login(string user, string pass)
        {
            if (logManager.log(user, pass, intentos))
            {
                bitacoraService.GuardarBitacoraDefault("Log in");
            }
            else
            {
                intentos += 1;
                bitacoraService.GuardarBitacora("Numero de intentos de login: " + intentos + " del usuario: " + user);
                throw new Exception(Session.traducciones["ErrorLogin"].Texto);
            }

        }
    }
}
