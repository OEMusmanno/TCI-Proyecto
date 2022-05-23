using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BE.Vehiculo.Estado;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Vehiculo.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Vehiculo.Estados
{
    public class DisponibleService : IEstadoService
    {

        private readonly IBitacoraService bitacoraService;
        public DisponibleService(IBitacoraService bitacoraService)
        {
            this.bitacoraService = bitacoraService;
        }

        public void cambioDeEstado(Reservado estado, Auto auto)
        {
            bitacoraService.GuardarBitacoraDefault("Cambio de estado a " + estado.nombre);
            auto.Estado = estado;
        }

        public void cambioDeEstado(Disponible estado, Auto auto)
        {
            throw new NotImplementedException();
        }
    }
}
