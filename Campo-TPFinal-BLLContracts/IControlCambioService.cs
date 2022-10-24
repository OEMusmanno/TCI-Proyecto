using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BE.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts
{
    public interface IControlCambioService
    {
        void AgregarVersionado(int UsuarioId, string value, string property, string descripcion);
        List<ControlCambio> Listar();
        void RestaurarVersion(string id);
    }
}
