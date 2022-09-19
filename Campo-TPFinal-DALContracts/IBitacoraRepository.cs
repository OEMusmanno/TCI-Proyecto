using Campo_TPFinal_BE.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts
{
    public interface IBitacoraRepository
    {
        void GuardarBitacora(string descripcion, string riesgo);
        List<BitacoraLog> Listar();
    }
}
