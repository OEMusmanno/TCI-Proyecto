using Campo_TPFinal_BE.Alquiler;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BE.Vehiculo.Estado;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Vehiculo;
using Campo_TPFinal_BLLContracts.Vehiculo.Estados;
using Campo_TPFinal_DALContracts.Vehiculo;

namespace Campo_TPFinal_BLL.Vehiculo
{
    public class AutoService:IAutoService
    {
        private readonly IAutoRepository _autoRepository;
        private readonly IEstacionamientoService estacionamientoService;        
        private readonly IBitacoraService bitacoraService;
        private readonly IEstadoService estadoService;

        public AutoService(
            IAutoRepository autoRepository, IEstadoService estadoService, IBitacoraService bitacoraService, IEstacionamientoService estacionamientoService)
        {
            _autoRepository = autoRepository;
            this.estadoService = estadoService;
            this.bitacoraService = bitacoraService;
            this.estacionamientoService = estacionamientoService;
        }

        public List<Auto> Listar() 
        {
            return _autoRepository.Listar();
        }

        public void CambioDeEstadoAReservado(Auto auto) {
            estadoService.cambioDeEstado(new Reservado(),auto);
        }

        public void EnviarACentralElAuto(int idEstacionamiento)
        {
            _autoRepository.EnviarACentralElAuto(idEstacionamiento);
        }

        public List<Auto> ListarTodo()
        {
            return _autoRepository.ListarTodo();
        }

        public Auto ObtenerPorId(int id)
        {
            return _autoRepository.ObtenerAuto(id);

        }

        public void Crear(string marca, string modelo, int estacionamiento, int tipoVehiculo)
        {
            _autoRepository.Crear(marca, modelo, estacionamiento,tipoVehiculo);
            estacionamientoService.OcuparEspacio(estacionamiento);
            bitacoraService.GuardarBitacora("Se creo un auto", "Bajo");
        }

        public void Actualizar(int id_auto,string marca, string modelo, int estacionamiento, int tipoVehiculo, bool bloqueado)
        {
            _autoRepository.Actualizar(id_auto, marca, modelo, estacionamiento, tipoVehiculo, bloqueado);
            estacionamientoService.OcuparEspacio(estacionamiento);
            bitacoraService.GuardarBitacora("Se actualizo un auto", "Bajo");
        }

        public void Borrar(int id_auto, int idEstacionamiento)
        {
            _autoRepository.Borrar(id_auto);
            estacionamientoService.liberarEspacio(idEstacionamiento);
            bitacoraService.GuardarBitacora("Se elimino un auto", "Bajo");
        }
      
    }
}
