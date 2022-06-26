using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BLLContracts.Sistema;
using Campo_TPFinal_DALContracts.Sistema.Idioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Sistema.Idioma
{
    public class TraductorService: ITraductorService
    {
        private readonly ITraductorRepository traductorRepository;

        public TraductorService(ITraductorRepository traductorRepository)
        {
            this.traductorRepository = traductorRepository;
        }

        public Lenguaje ObtenerIdiomaDefault()
        {
            return traductorRepository.ObtenerIdiomaDefault();
        }

        public List<Lenguaje> ObtenerIdiomas()
        {
            return traductorRepository.ObtenerIdiomas();
        }

        public IDictionary<string, Traduccion> ObtenerTraducciones(Lenguaje idioma = null)
        {
            return traductorRepository.ObtenerTraducciones(idioma);
        }
    }
}
