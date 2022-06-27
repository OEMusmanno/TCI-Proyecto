using Campo_TPFinal_BE.Alquiler;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Alquiler;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Alquiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Alquiler
{
    public class AlquilerService : IAlquilerService
    {
        private readonly IAlquilerRepository alquilerRepository;
        private readonly IBitacoraService bitacoraService;
        private readonly IAutoRepository autoRepository;


        public AlquilerService(IAlquilerRepository alquilerRepository, IBitacoraService bitacoraService, IAutoRepository autoRepository)
        {
            this.alquilerRepository = alquilerRepository;
            this.bitacoraService = bitacoraService;
            this.autoRepository = autoRepository;
        }

        public void RegistrarReserva(int id, string marca, string modelo)
        {
            if (!validarReservasAnteriores())
            {
                alquilerRepository.RegistrarReserva(id);
                bitacoraService.GuardarBitacoraDefault("Se registro la reserva con el auto: " + marca + " " + modelo);
            }
            else
            {
                bitacoraService.GuardarBitacoraDefault("Error de Validacion de reserva: Reserva Activa");
                throw new Exception("Se encuentra una reserva activa");
            }

        }

        public Reserva obtenerAlquiler() {
            var reserva = alquilerRepository.ObtenerReserva(Session.GetInstance().usuario.Id);
             reserva.auto=  autoRepository.ObtenerAuto(reserva.id_auto);
            return reserva;
        }

        public bool validarReservasAnteriores()
        {
            return alquilerRepository.ValidarReservasAnteriores();         
        }

        public void FinalizarReserva()
        {
            alquilerRepository.FinalizarReserva();
        }
    }
}
