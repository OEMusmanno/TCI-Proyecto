using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_DALContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL
{
    public class BitacoraService: IBitacoraService
    {
        private readonly IBitacoraRepository bitacoraRepository;

        public BitacoraService(IBitacoraRepository bitacoraRepository)
        {
            this.bitacoraRepository = bitacoraRepository;
        }
        public void GuardarBitacora(string descripcion)
        {
            bitacoraRepository.GuardarBitacora(descripcion);
        }
        
        public void GuardarBitacoraDefault(string descripcion)
        {
            bitacoraRepository.GuardarBitacora("El usuario: " + Session.GetInstance().usuario.alias +" - "+ descripcion);
        }
    }
}
