using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_DALContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL
{
    public class ControlCambioService : IControlCambioService
    {
        readonly IControlCambioRepository controlCambioRepository;

        public ControlCambioService(IControlCambioRepository controlCambioRepository)
        {
            this.controlCambioRepository = controlCambioRepository;
        }

        public List<ControlCambio> Listar() { 
            return controlCambioRepository.Listar();        
        }

        public void AgregarVersionado(string version, string descripcion) 
        { 
            controlCambioRepository.GuardarCambios(version, descripcion);
        
        }

    }
}
