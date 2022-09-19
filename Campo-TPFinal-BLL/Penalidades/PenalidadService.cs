using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Penalidad;
using Campo_TPFinal_DALContracts;

namespace Campo_TPFinal_BLL.Penalidades
{
    public class PenalidadService : IPenalidadService
    {
        private readonly IPenalidadRepository penalidadRepository;
        private readonly IBitacoraService bitacoraService;

        public PenalidadService(IPenalidadRepository penalidadRepository, IBitacoraService bitacoraService)
        {
            this.penalidadRepository = penalidadRepository;
            this.bitacoraService = bitacoraService;
        }

        public List<Penalidad> Listar()
        {
            return penalidadRepository.Listar();
        }

        public void AplicarPenalidad(string penalidad, int idUsuario)
        {
            var idPenalidad = penalidadRepository.ObtenerPenalidad(penalidad);
            penalidadRepository.AplicarPenalidad(idPenalidad, idUsuario);
            //bitacoraService.GuardarBitacora("aplico una sancion");
        }
    }
}
