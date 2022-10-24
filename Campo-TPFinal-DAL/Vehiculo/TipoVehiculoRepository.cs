using Campo_TPFinal_BE.Vehiculo;
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
    public class TipoVehiculoRepository : ITipoVehiculoRepository
    {

        private readonly IDataAccess dataAccess;

        public TipoVehiculoRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public List<TipoVehiculo> Listar()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM[Campo].[dbo].[TipoVehiculo]");
            var _list = new List<TipoVehiculo>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                TipoVehiculo _estacionamiento = new TipoVehiculo();
                ValorizarEntidad(_estacionamiento, item);
                _list.Add(_estacionamiento);
            }

            return _list;
        }

        public TipoVehiculo ObtenerPorId(int id)
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM[Campo].[dbo].[TipoVehiculo] WHERE Id = " + id);
            TipoVehiculo _tipoVehiculo = new TipoVehiculo();
            ValorizarEntidad(_tipoVehiculo, list.Tables[0].Rows[0]);
            return _tipoVehiculo;
        }

        void ValorizarEntidad(TipoVehiculo tipoVehiculo, DataRow pDataRow)
        {
            tipoVehiculo.Id = int.Parse(pDataRow["Id"].ToString());
            tipoVehiculo.Nombre = pDataRow["Nombre"].ToString();
            tipoVehiculo.MinutoRecorrido = double.Parse(pDataRow["MinutoRecorrido"].ToString());
            tipoVehiculo.MinutoDetenido = double.Parse(pDataRow["MinutoDetenido"].ToString());
            tipoVehiculo.PrecioDia = double.Parse(pDataRow["PrecioDia"].ToString());
            tipoVehiculo.PrecioHora = double.Parse(pDataRow["PrecioHora"].ToString());
            tipoVehiculo.PrecioKmExtra = double.Parse(pDataRow["PrecioKmExtra"].ToString());

        }
    }
}
