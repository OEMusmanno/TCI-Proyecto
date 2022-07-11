using Campo_TPFinal_BE.Sistema.Idioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts.Sistema.Idioma
{
    public interface ITraductorRepository
    {
        Lenguaje ObtenerIdiomaDefault();
        List<Lenguaje> ObtenerIdiomas();

        IDictionary<string, Traduccion> ObtenerTraducciones(Lenguaje idioma = null);
        void CrearIdioma(string nombre);
        Lenguaje ObtenerIdioma(string nombre);
        void CrearTraduccionesVaciasParaNuevoIdioma(int id_Idioma);
        void BorrarIdioma(int id);
        void EditarTraduccion(string texto, int id);
    }
}
