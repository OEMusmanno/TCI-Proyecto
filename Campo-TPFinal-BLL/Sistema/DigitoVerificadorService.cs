using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Sistema
{
    public class DigitoVerificadorService : IDigitoVerificadorService
    {
        readonly IDigitoVerificadorRepository digitoVerificadorRepository;
        readonly IBitacoraService bitacoraService;


        public DigitoVerificadorService(IDigitoVerificadorRepository digitoVerificadorRepository, IBitacoraService bitacoraService)
        {
            this.digitoVerificadorRepository = digitoVerificadorRepository;
            this.bitacoraService = bitacoraService;
        }

        void CalcularDigitoVerificadorHorizontal()
        {
            digitoVerificadorRepository.CalcularDigitoVerificadorHorizontal();
            bitacoraService.GuardarBitacora("Se realiza el calculo horizontal", "Alta");
        }

        void CalcularDigitoVerificadorVertical()
        {
            digitoVerificadorRepository.CalcularDigitoVerificadorVertical();
            bitacoraService.GuardarBitacora("Se realiza el calculo vertical","Alta");
        }

        bool CheckDigitoVerificadorHorizontal()
        {
            bitacoraService.GuardarBitacora("Se realiza la verificacion horizontal", "Alta");
            return digitoVerificadorRepository.CheckDigitoVerificadorHorizontal();
        }

        bool CheckDigitoVerificadorVertical()
        {
            bitacoraService.GuardarBitacora("Se realiza la verificacion vertical", "Alta");
            return digitoVerificadorRepository.CheckDigitoVerificadorVertical();
        }

        public bool CheckDigitoVerificador() { 
            return CheckDigitoVerificadorHorizontal() && CheckDigitoVerificadorVertical() ;
        }

        public void CalcularDigitoVerificador()
        {
            CalcularDigitoVerificadorHorizontal();
            CalcularDigitoVerificadorVertical();
        }
    }
}
