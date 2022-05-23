using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BE.Vehiculo.Estado;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Vehiculo.Estados;
using Campo_TPFinal_DALContracts;

namespace Campo_TPFinal_BLL.Vehiculo
{
    public class AutoService:IAutoService
    {
        private readonly IAutoRepository _autoRepository;
        private readonly IEstadoService estadoService;

        public AutoService(
            IAutoRepository autoRepository, IEstadoService estadoService)
        {
            _autoRepository = autoRepository;
            this.estadoService = estadoService;
        }

        public List<Auto> Listar() 
        {
            return _autoRepository.Listar();
        }

        public void CambioDeEstadoAReservado(Auto auto) {
            estadoService.cambioDeEstado(new Reservado(),auto);
        }
    }
}
