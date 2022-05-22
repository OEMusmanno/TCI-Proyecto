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
        void RegistrarReserva(int id, string marca, string modelo);
    }
}
