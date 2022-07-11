using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BE.Vehiculo.Estado;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Vehiculo.Estados;

namespace Campo_TPFinal_BLL.Vehiculo.Estados
{
    public class ReservadoService : IEstadoService
    {

        private readonly IBitacoraService bitacoraService;

        public ReservadoService(IBitacoraService bitacoraService)
        {
            this.bitacoraService = bitacoraService;
        }

        public void cambioDeEstado(Reservado estado, Auto auto)
        {
            throw new NotImplementedException();
        }

        public void cambioDeEstado(Disponible estado, Auto auto)
        {
            throw new NotImplementedException();
        }

        public void cambioDeEstado(bool estado, Auto auto)
        {
            bitacoraService.GuardarBitacoraDefault(String.Format("Cambio de estado a {0}", (estado == false ? "Disponible" : "Ocupado")));
            auto.Estado = estado;
            
        }
    }
}
