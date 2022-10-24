using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_DALContracts.Sistema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts.Vehiculo
{
    public interface IAutoRepository
    {
        void Actualizar(int id_auto, string marca, string modelo, int estacionamiento, int tipoVehiculo, bool bloqueado);
        void Borrar(int id_auto);
        void Crear(string marca, string modelo, int estacionamiento, int tipoVehiculo);
        void EnviarACentralElAuto(int idEstacionamiento);
        List<Auto> Listar();
        List<Auto> ListarTodo();
        Auto ObtenerAuto(int idAuto);
    }
}
