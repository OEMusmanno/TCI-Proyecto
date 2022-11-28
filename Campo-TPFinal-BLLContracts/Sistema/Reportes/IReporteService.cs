using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.Sistema.Reportes
{
    public interface IReporteService
    {
        void SacarReporteDeGanancias(string path, DateTime fechaInicio, DateTime fechaFin);
    }
}
