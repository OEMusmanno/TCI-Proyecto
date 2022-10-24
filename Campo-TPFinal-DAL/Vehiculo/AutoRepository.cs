using Campo_TPFinal_BE;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLLContracts.Vehiculo;
using Campo_TPFinal_DALContracts.Sistema.DB;
using Campo_TPFinal_DALContracts.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL.Vehiculo
{
    public class AutoRepository : IAutoRepository
    {
        private readonly IDataAccess dataAccess;
        private readonly ITipoVehiculoService _tipoVehiculoService;
        private readonly IEstacionamientoService _estacionamiento;

        public AutoRepository(IDataAccess dataAccess, ITipoVehiculoService tipoVehiculoService, IEstacionamientoService estacionamiento)
        {
            this.dataAccess = dataAccess;
            _tipoVehiculoService = tipoVehiculoService;
            _estacionamiento = estacionamiento;
        }

        public void Actualizar(int id_auto, string marca, string modelo, int estacionamiento, int tipoVehiculo, bool bloqueado)
        {
            var estado = Convert.ToInt16(bloqueado);
            string _commandText = $"UPDATE [dbo].[Auto] SET [marca] = '{marca}' ,[modelo] ='{modelo}' ,[Id_Estacionamiento] ={estacionamiento} ,[Id_TipoVehiculo] ={tipoVehiculo},[Estado] ={estado} WHERE id = {id_auto}";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public void Crear(string marca, string modelo, int estacionamiento, int tipoVehiculo)
        {           
            string _commandText = $"INSERT INTO Auto (Marca,Modelo,id_Estacionamiento,id_TipoVehiculo, estado) VALUES ('{marca}','{modelo}',{estacionamiento} ,{tipoVehiculo}, 0)";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public void Borrar(int id_auto)
        {
            string _commandText =$"DELETE FROM [dbo].[auto] WHERE id = {id_auto}";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public void EnviarACentralElAuto(int idEstacionamiento)
        {
            string _commandText = $"UPDATE [dbo].[Auto] SET [id_Estacionaminto] = (SELECT id FROM Estacionamiento Where Ubicacion = 'Central') , espaciosLibre = (SELECT espaciosLibres -1 FROM [Campo].[dbo].[Estacionamiento] Where Ubicacion = 'Central') WHERE id_Estacionaminto = {idEstacionamiento}";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public List<Auto> Listar()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [dbo].[Auto] WHERE ESTADO = 0");
            var _list = new List<Auto>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Auto _auto = new Auto();
                ValorizarEntidad(_auto, item);
                _list.Add(_auto);
            }
            return _list;
        }

        public List<Auto> ListarTodo()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [dbo].[Auto]");
            var _list = new List<Auto>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Auto _auto = new Auto();
                ValorizarEntidad(_auto, item);
                _list.Add(_auto);
            }
            return _list;
        }
        public Auto ObtenerAuto(int idAuto)
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [dbo].[Auto] where id= " + idAuto);
            var _list = new List<Auto>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Auto _auto = new Auto();
                ValorizarEntidad(_auto, item);
                _list.Add(_auto);
            }
            return _list.FirstOrDefault();
        }


        void ValorizarEntidad(Auto auto, DataRow pDataRow)
        {
            auto.Marca = pDataRow["Marca"].ToString();
            auto.Modelo = pDataRow["Modelo"].ToString();
            auto.Id = int.Parse(pDataRow["Id"].ToString());
            auto.tipoVehiculo = _tipoVehiculoService.ObtenerPorId(int.Parse(pDataRow["id_TipoVehiculo"].ToString()));
            auto.Estado = (bool)pDataRow["Estado"];
            auto.Estacionamiento = _estacionamiento.ObtenerPorId(int.Parse(pDataRow["id_Estacionamiento"].ToString()));
        }

    }
}
