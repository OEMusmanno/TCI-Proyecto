using Campo_TPFinal_BE.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts
{
    public interface IControlCambioService
    {
        void AgregarVersionado(string version, string descripcion);
        List<ControlCambio> Listar();
    }
}
