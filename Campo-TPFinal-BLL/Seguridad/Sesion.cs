using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_DALContracts.Sistema.Idioma;
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
        public Usuario usuario { get; set; }

        static IList<IIdiomaService> _observers = new List<IIdiomaService>();

        private static Session instance;

        public static IDictionary<string, Traduccion> traducciones;

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

        public static bool IsLogged()
        {
            return instance != null;
        }
        public static void Logout()
        {
            instance = null;
            Notificar(new Lenguaje() { Nombre = "Español", id = 1 });
        }

        public static void SuscribirObservador(IIdiomaService o)
        {
            _observers.Add(o);
        }
        public static void DesuscribirObservador(IIdiomaService o)
        {
            _observers.Remove(o);
        }

        private static void Notificar(Lenguaje idioma)
        {
            foreach (var o in _observers)
            {
                o.ActualizarLenguaje(idioma);
            }
        }
        public static void CambiarIdioma(Lenguaje idioma)
        {
            if (instance != null)
            {
                instance.usuario.idioma = idioma;
            }
            Notificar(idioma);
        }
    }
}
