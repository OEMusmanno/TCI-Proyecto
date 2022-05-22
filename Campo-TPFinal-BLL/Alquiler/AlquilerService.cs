using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Alquiler;
using Campo_TPFinal_DALContracts.Alquiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Alquiler
{
    public class AlquilerService: IAlquilerService
    {
        private readonly IAlquilerRepository alquilerRepository;
        private readonly IBitacoraService bitacoraService;

        public AlquilerService(IAlquilerRepository alquilerRepository, IBitacoraService bitacoraService)
        {
            this.alquilerRepository = alquilerRepository;
            this.bitacoraService = bitacoraService;
        }

        public void RegistrarReserva(int id) {
            alquilerRepository.RegistrarReserva(id);
        }


    }
}
