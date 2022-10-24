using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Vehiculo;
using Campo_TPFinal_DALContracts.Vehiculo;

namespace Campo_TPFinal_BLL.Vehiculo
{
    public class EstacionamientoService : IEstacionamientoService
    {

        private readonly IBitacoraService bitacoraService;
        private readonly IAutoService autoService;

        private readonly IEstacionamientoRepository estacionamientoRepository;

        public EstacionamientoService(IEstacionamientoRepository estacionamientoRepository, IBitacoraService bitacoraService)
        {
            this.estacionamientoRepository = estacionamientoRepository;
            this.bitacoraService = bitacoraService;
        }

        public void Actualizar(string id, string ubicacion, int espacios)
        {
            estacionamientoRepository.Actualizar(id,ubicacion,espacios);
            bitacoraService.GuardarBitacora("Se actualizo un estacionamiento", "Bajo");
        }

        public void Borrar(int idEstacionamiento)
        {
            autoService.EnviarACentralElAuto(idEstacionamiento);
            estacionamientoRepository.Borrar(idEstacionamiento);
            bitacoraService.GuardarBitacora("Se elimino un estacionamiento", "Bajo");
        }

        public void Crear(string ubicacion, int espacios)
        {
            estacionamientoRepository.Crear(ubicacion,espacios);
            bitacoraService.GuardarBitacora("Se creo un estacionamiento", "Bajo");
        }

        public void liberarEspacio(int idEstacionamiento)
        {
            estacionamientoRepository.liberarEspacio(idEstacionamiento);
        }

        public List<Estacionamiento> Listar()
        {
            return estacionamientoRepository.Listar();
        }

        public Estacionamiento ObtenerPorId(int id)
        {
            return estacionamientoRepository.ObtenerPorId(id);
        }

        public int ObtenerTotalEspaciosLibres()
        {
            return estacionamientoRepository.ObtenerTotalEspaciosLibres();
        }

        public void OcuparEspacio(int id)
        {
            estacionamientoRepository.OcuparEspacio(id);
        }
    }
}
