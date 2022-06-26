using Campo_TPFinal_BE.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.Sistema
{
    public interface ITraductorService
    {
        Lenguaje ObtenerIdiomaDefault();
        List<Lenguaje> ObtenerIdiomas();

        IDictionary<string, Traduccion> ObtenerTraducciones(Lenguaje idioma = null);
    }
}
