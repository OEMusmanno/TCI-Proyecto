using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.Sistema
{
    public interface IDigitoVerificadorService
    {
        void CalcularDigitoVerificador();
        bool CheckDigitoVerificador();
    }
}
