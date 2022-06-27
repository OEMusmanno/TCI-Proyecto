using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Sistema
{
    public static class ManejadorDeSesion
    {
        static Usuario _session;

        static IList<IIdiomaService> _observers = new List<IIdiomaService>();
        public static Usuario Session
        {
            get
            {
                return _session;
            }

        }

        public static bool IsLogged()
        {
            return _session != null;
        }
        public static void Login(Usuario usuario)
        {
            _session = usuario;
        }

        public static void Logout()
        {
            _session = null;
            //Notificar(Traductor.ObtenerIdiomaDefault());
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
            if (_session != null)
            {
                //_session.Idioma = idioma;
                Notificar(idioma);
            }
        }
    }
}
