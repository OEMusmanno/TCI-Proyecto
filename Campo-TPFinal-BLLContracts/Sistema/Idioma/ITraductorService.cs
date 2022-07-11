using Campo_TPFinal_BE.Sistema.Idioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.Sistema.Idioma
{
    public interface ITraductorService
    {
        void BorrarIdioma(int id);
        void CrearNuevoIdioma(string Nombre);
        void EditarTraduccion(string texto, int id);
        Lenguaje ObtenerIdiomaDefault();
        List<Lenguaje> ObtenerIdiomas();
        IDictionary<string, Traduccion> ObtenerTraducciones(Lenguaje idioma = null);

    }
}
