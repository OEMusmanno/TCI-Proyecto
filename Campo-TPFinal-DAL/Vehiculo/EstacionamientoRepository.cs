using Campo_TPFinal_BE;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Vehiculo;
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

        void ValorizarEntidad(Estacionamiento _estacionamiento, DataRow pDataRow)
        {
            _estacionamiento.ubicacion = pDataRow["ubicacion"].ToString();
            _estacionamiento.Id = int.Parse(pDataRow["Id"].ToString());

        }
    }
}
