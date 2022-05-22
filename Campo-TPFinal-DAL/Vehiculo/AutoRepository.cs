﻿using Campo_TPFinal_BE;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_DALContracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL
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

        public List<Auto> Listar()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM[Campo].[dbo].[Auto]");
            var _list = new List<Auto>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Auto _auto = new Auto();
                ValorizarEntidad(_auto, item);
                _list.Add(_auto);
            }
            return _list;
        }
        void ValorizarEntidad(Auto auto, DataRow pDataRow)
        {
            auto.Marca = pDataRow["Marca"].ToString();
            auto.Modelo = pDataRow["Modelo"].ToString();
            auto.Id = int.Parse(pDataRow["Id"].ToString());
            auto.tipoVehiculo = _tipoVehiculoService.ObtenerPorId(int.Parse(pDataRow["id_TipoVehiculo"].ToString()));
            auto.Estacionamiento = _estacionamiento.ObtenerPorId(int.Parse(pDataRow["id_Estacionamiento"].ToString()));
        }

    }
}
