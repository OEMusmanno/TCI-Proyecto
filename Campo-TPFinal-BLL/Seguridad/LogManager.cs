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

        public LogManager(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public bool log(string name, string pass)
        {
            var sesion = Session.GetInstance();
            if (name == "" || pass == "")
            {
                throw new Exception("Debe Ingresar todos los campos");
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
