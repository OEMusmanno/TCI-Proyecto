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
        void GuardarCambios(int UsuarioId, string value, string property, string descripcion);
        List<ControlCambio> Listar();
        void RestaurarVersion(string id);
    }
}
