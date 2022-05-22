using Campo_TPFinal_BE.Auto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts
{
    public interface ITipoVehiculoService
    {
        public List<TipoVehiculo> Listar();
        public TipoVehiculo ObtenerPorId(int id);

    }
}
