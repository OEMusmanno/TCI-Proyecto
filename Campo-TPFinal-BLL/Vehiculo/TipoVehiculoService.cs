using Campo_TPFinal_BE.Auto;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Vehiculo
{
    public class TipoVehiculoService : ITipoVehiculoService
    {
        private readonly ITipoVehiculoRepository tipoVehiculoRepository;

        public TipoVehiculoService(ITipoVehiculoRepository tipoVehiculoRepository)
        {
            this.tipoVehiculoRepository = tipoVehiculoRepository;
        }

        public List<TipoVehiculo> Listar()
        {
            return tipoVehiculoRepository.Listar();
        }

        public TipoVehiculo ObtenerPorId(int id)
        {
            return tipoVehiculoRepository.ObtenerPorId(id);
        }

       
    }
}
