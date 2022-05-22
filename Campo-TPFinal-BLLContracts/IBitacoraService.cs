using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts
{
    public interface IBitacoraService
    {
        void GuardarBitacora(string descripcion);
        void GuardarBitacoraDefault(string descripcion);
    }
}
