using Campo_TPFinal_BE.Solicitud;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DAL.Sistema.DB;
using Campo_TPFinal_DAL.Vehiculo;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using Campo_TPFinal_DALContracts.SolicitudDeCompra;
using Campo_TPFinal_DALContracts.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL.SolicitudDeCompra
{
    public class SolicitudDeCompraRepository : ISolicitudDeCompraRepository
    {
        private readonly IDataAccess dataAccess;
        private readonly ITipoVehiculoRepository tipoVehiculoRepository;
        private readonly IUsuarioRepository usuarioRepository;


        public SolicitudDeCompraRepository(IDataAccess dataAccess, ITipoVehiculoRepository tipoVehiculoRepository, IUsuarioRepository usuarioRepository)
        {
            this.dataAccess = dataAccess;
            this.tipoVehiculoRepository = tipoVehiculoRepository;
            this.usuarioRepository = usuarioRepository;
        }

        public void Crear(SolicitudCompra solicitudDeCompra)
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss.FFF";
            string _commandText = $"INSERT INTO SolicitudDeCompra ([total],[fechaDeSolicitud],[id_usuario]) VALUES ('{solicitudDeCompra.Total}','{fechaHora.ToString(format)}','{(Session.GetInstance()?.usuario?.Id ?? 102)}' )";
            dataAccess.ExecuteNonQuery(_commandText);
            var id_Solicitud = $"(SELECT [Id] FROM [Campo].[dbo].[SolicitudDeCompra] WHERE fechaDeSolicitud = '{fechaHora.ToString(format)}' AND id_usuario ={(Session.GetInstance()?.usuario?.Id ?? 102)})";            
            foreach (var item in solicitudDeCompra.itemDeCompras)
            {
                _commandText = $"INSERT INTO ItemSolicitudCompra ([Marca],[Modelo],[precioUnitario],[cantidad],[tipoCambio],[tipoPago],[id_SolicitudDeCompra]) VALUES ('{item.Marca}','{item.Modelo}',{item.precioUnitario},{item.cantidad},{(int)item.TipoCambio},{(int)item.TipoPago},{id_Solicitud} )";
                dataAccess.ExecuteNonQuery(_commandText);
            }                        
        }


        public SolicitudCompra ObtenerPorId(int id)
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[ItemSolicitudCompra] WHERE [id_SolicitudDeCompra] = " + id);
            SolicitudCompra solicitudCompra = new SolicitudCompra();
            ValorizarEntidad(solicitudCompra, list.Tables[0].Rows[0]);
            return solicitudCompra;
        }


        public List<ItemDeCompra> Listar(int IdSolicitudCompra)
        {
            var list = dataAccess.ExecuteDataSet($"SELECT * FROM[Campo].[dbo].[ItemSolicitudCompra] WHERE id_solicitudDeCompra = {IdSolicitudCompra}");
            var _list = new List<ItemDeCompra>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                ItemDeCompra itemDeCompra = new ItemDeCompra();
                ValorizarEntidad(itemDeCompra, item);
                _list.Add(itemDeCompra);
            }

            return _list;
        }
        public List<SolicitudCompra> Listar()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM[Campo].[dbo].[SolicitudDeCompra]");
            var _list = new List<SolicitudCompra>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                SolicitudCompra solicitudCompra = new SolicitudCompra();
                ValorizarEntidad(solicitudCompra, item);
                _list.Add(solicitudCompra);
            }

            return _list;
        }

        void ValorizarEntidad(SolicitudCompra solicitudCompra, DataRow pDataRow)
        {
            solicitudCompra.Id = int.Parse(pDataRow["Id"].ToString());
            solicitudCompra.Usuario = usuarioRepository.ObtenerPorId( int.Parse(pDataRow["Id_usuario"].ToString()));
            solicitudCompra.itemDeCompras = Listar(solicitudCompra.Id);
            solicitudCompra.Total = double.Parse(pDataRow["Total"].ToString());
            solicitudCompra.fechaDeSolicitud = DateTime.Parse(pDataRow["fechaDeSolicitud"].ToString());

        }

        void ValorizarEntidad(ItemDeCompra itemDeCompra, DataRow pDataRow)
        {
            itemDeCompra.Id = int.Parse(pDataRow["Id"].ToString());
            itemDeCompra.Marca = pDataRow["Marca"].ToString();
            itemDeCompra.Modelo = pDataRow["Modelo"].ToString();
            itemDeCompra.TipoCambio = (TipoCambio)pDataRow["TipoCambio"]; 
            itemDeCompra.TipoPago = (TipoPago)pDataRow["TipoPago"];
            itemDeCompra.cantidad = int.Parse(pDataRow["cantidad"].ToString());
            itemDeCompra.precioUnitario = double.Parse(pDataRow["precioUnitario"].ToString());
            itemDeCompra.tipoVehiculo = tipoVehiculoRepository.ObtenerPorId( int.Parse(pDataRow["tipoVehiculo"].ToString()));

        }

    }
}
