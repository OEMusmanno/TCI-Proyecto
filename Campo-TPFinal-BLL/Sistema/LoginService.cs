using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;

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
                bitacoraService.GuardarBitacora("Log in", "Bajo");
            }
            else
            {
                intentos += 1;
                bitacoraService.GuardarBitacora("Numero de intentos de login: " + intentos + " del usuario: " + user , "Alto");
                throw new Exception(Session.traducciones["ErrorLogin"].Texto);
            }
        }       
    }
}
