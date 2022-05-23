using Campo_TPFinal_BE.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts
{
    public interface IPenalidadRepository
    {
        List<Penalidad> Listar();
        void AplicarPenalidad(int idPenalidad, int idUsuario);
        int ObtenerPenalidad(string penalidad);
    }
}
