using Campo_TPFinal_BE.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts
{
    public interface IControlCambioRepository
    {
        void GuardarCambios(string Version, string descripcion);
        List<ControlCambio> Listar();
    }
}
