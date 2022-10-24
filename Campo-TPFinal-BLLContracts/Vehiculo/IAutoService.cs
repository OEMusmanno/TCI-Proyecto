using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BE.Vehiculo.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.Vehiculo
{
    public interface IAutoService
    {
        void Actualizar(int id ,string marca, string modelo, int estacionamiento, int tipoVehiculo, bool bloqueado);
        void Borrar(int id_auto, int id_Estacionamiento);
        void CambioDeEstadoAReservado(Auto auto);
        void Crear(string marca, string modelo, int estacionamiento, int tipoVehiculo);
        void EnviarACentralElAuto(int idEstacionamiento);
        public List<Auto> Listar();
        public List<Auto> ListarTodo();
        Auto ObtenerPorId(int id);
    }
}
