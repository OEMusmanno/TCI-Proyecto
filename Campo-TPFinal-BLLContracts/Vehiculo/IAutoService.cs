using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BE.Vehiculo.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts
{
    public interface IAutoService
    {
        void CambioDeEstadoAReservado(Auto auto);
        public List<Auto> Listar();
    }
}
