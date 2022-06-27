using Campo_TPFinal_BE.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts
{
    public interface IAutoRepository
    {
        List<Auto> Listar();
        Auto ObtenerAuto(int idAuto);
    }
}
