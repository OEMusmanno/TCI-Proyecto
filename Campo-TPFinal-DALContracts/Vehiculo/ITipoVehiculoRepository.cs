using Campo_TPFinal_BE.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts.Vehiculo
{
    public interface ITipoVehiculoRepository
    {
        List<TipoVehiculo> Listar();
        TipoVehiculo ObtenerPorId(int id);

    }
}
