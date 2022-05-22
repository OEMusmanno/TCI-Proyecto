using Campo_TPFinal_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts
{
    public interface IEstacionamientoService
    {
        public List<Estacionamiento> Listar();
        public Estacionamiento ObtenerPorId(int id);
    }
}
