using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_DAL.Sistema.DB;
using Campo_TPFinal_DALContracts.Sistema.DB;
using Campo_TPFinal_DALContracts.Vehiculo;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL.Vehiculo
{
    public class EstacionamientoRepository: IEstacionamientoRepository
    {

        private readonly IDataAccess dataAccess;

        public EstacionamientoRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void Actualizar(string id, string ubicacion, int espacios)
        {
            string _commandText = $"UPDATE [dbo].[Estacionamiento] SET [ubicacion] = '{ubicacion}' ,[espacios] ={espacios} WHERE id = {id}";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public void Borrar(int idEstacionamiento)
        {
            string _commandText = "DELETE FROM [dbo].[Estacionamiento] WHERE id = " + idEstacionamiento;
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public void Crear(string ubicacion, int espacios)
        {
            string _commandText = $"INSERT INTO estacionamiento (ubicacion,espacios) VALUES ('{ubicacion}','{espacios}' )";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public void liberarEspacio(int idEstacionamiento)
        {
            string _commandText = $"UPDATE [dbo].[Estacionamiento] SET [espaciosLibres] = (espaciosLibres +1)  WHERE id =  {idEstacionamiento}";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public List<Estacionamiento> Listar()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM[Campo].[dbo].[Estacionamiento]");
            var _list = new List<Estacionamiento>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Estacionamiento _estacionamiento = new Estacionamiento();
                ValorizarEntidad(_estacionamiento, item);
                _list.Add(_estacionamiento);
            }

            return _list;
        }

        public Estacionamiento ObtenerPorId(int id)
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM[Campo].[dbo].[Estacionamiento] WHERE Id = " + id);
            Estacionamiento _estacionamiento = new Estacionamiento();
            ValorizarEntidad(_estacionamiento, list.Tables[0].Rows[0]);
            return _estacionamiento;
        }

        public void OcuparEspacio(int id)
        {
            string _commandText = $"UPDATE [dbo].[Estacionamiento] SET [espaciosLibres] = (espaciosLibres -1)  WHERE id =  {id}";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        void ValorizarEntidad(Estacionamiento _estacionamiento, DataRow pDataRow)
        {
            _estacionamiento.ubicacion = pDataRow["ubicacion"].ToString();
            _estacionamiento.Id = int.Parse(pDataRow["Id"].ToString());
            _estacionamiento.espaciosTotal = int.Parse(pDataRow["espaciosTotal"].ToString());
            _estacionamiento.espaciosLibres = int.Parse(pDataRow["espaciosLibres"].ToString());

        }
    }
}
