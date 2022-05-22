using Campo_TPFinal_BE;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Vehiculo
{
    public class EstacionamientoService : IEstacionamientoService
    {

        private readonly IEstacionamientoRepository estacionamientoRepository;

        public EstacionamientoService(IEstacionamientoRepository estacionamientoRepository)
        {
            this.estacionamientoRepository = estacionamientoRepository;
        }

        public List<Estacionamiento> Listar()
        {
            return estacionamientoRepository.Listar();
        }

        public Estacionamiento ObtenerPorId(int id)
        {
            return estacionamientoRepository.ObtenerPorId(id);
        }

        
    }
}
