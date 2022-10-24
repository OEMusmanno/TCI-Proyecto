using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema;
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
        readonly IDigitoVerificadorService digitoVerificadorService;

        public ControlCambioService(IControlCambioRepository controlCambioRepository, IDigitoVerificadorService digitoVerificadorService)
        {
            this.controlCambioRepository = controlCambioRepository;
            this.digitoVerificadorService = digitoVerificadorService;
        }

        public void AgregarVersionado(int UsuarioId, string value, string property, string descripcion)
        {
            controlCambioRepository.GuardarCambios(UsuarioId, value, property, descripcion);
        }

        public List<ControlCambio> Listar()
        {
            return controlCambioRepository.Listar();
        }

        public void RestaurarVersion(string id)
        {
            controlCambioRepository.RestaurarVersion(id);
            digitoVerificadorService.CalcularDigitoVerificador();
        }
    }
}
