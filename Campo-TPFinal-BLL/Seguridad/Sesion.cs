using Campo_TPFinal_BE.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Seguridad
{
    public class Session
    {
        private Session() { }
        public Usuario usuario{ get; set; }

        private static Session instance;

        public static Session GetInstance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }

        public static void CloseSession()
        {
            instance = null;
        }
    }
}
