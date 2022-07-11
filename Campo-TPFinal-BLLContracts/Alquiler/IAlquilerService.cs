using Campo_TPFinal_BE.Alquiler;
using Campo_TPFinal_BE.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.Alquiler
{
    public interface IAlquilerService
    {
        Reserva obtenerAlquiler();
        void RegistrarReserva(int id, string marca, string modelo);
        bool validarReservasAnteriores();
        void FinalizarReserva(int id_auto);
    }
}
