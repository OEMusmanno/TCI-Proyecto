using Campo_TPFinal_BE;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_DALContracts;
using System.Data;

namespace Campo_TPFinal_BLL.Vehiculo
{
    public class AutoService:IAutoService
    {
        private readonly IDataAccess _dataAccess;
        private readonly IAutoRepository _autoRepository;
        private readonly ITipoVehiculoService _tipoVehiculoService;
        private readonly IEstacionamientoService _estacionamiento;

        public AutoService(
            IDataAccess dataAccess
            , ITipoVehiculoService tipoVehiculoService
            , IEstacionamientoService estacionamiento
            , IAutoRepository autoRepository)
        {
            this._dataAccess = dataAccess;
            this._tipoVehiculoService = tipoVehiculoService;
            this._estacionamiento = estacionamiento;
            _autoRepository = autoRepository;
        }

        public List<Auto> Listar() 
        {
            return _autoRepository.Listar();
        }        
    }
}
