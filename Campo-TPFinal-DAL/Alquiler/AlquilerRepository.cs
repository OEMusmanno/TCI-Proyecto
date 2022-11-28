using Campo_TPFinal_BE.Alquiler;
using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts.Alquiler;
using Campo_TPFinal_BLLContracts.Sistema.Perfil;
using Campo_TPFinal_BLLContracts.Vehiculo;
using Campo_TPFinal_DAL.Sistema.DB;
using Campo_TPFinal_DALContracts.Alquiler;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL.Alquiler
{
    public class AlquilerRepository: IAlquilerRepository
    {
        private readonly IDataAccess dataAccess;
        private readonly IUsuarioService usuarioService;
        private readonly IAutoService autoService;



        public AlquilerRepository(IDataAccess dataAccess, IUsuarioService usuarioService, IAutoService autoService)
        {
            this.dataAccess = dataAccess;
            this.usuarioService = usuarioService;
            this.autoService = autoService;
        }

        public void FinalizarReserva(int id_auto)
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-ddTHH:mm:ss.FFF";
            var query  = string.Format("UPDATE [dbo].[Reserva] SET [fechaFin] = '{0}' where id_auto = {1} and [fechaFin] IS NULL ", fechaHora.ToString(format), id_auto);
            dataAccess.ExecuteNonQuery(query);
            CambiarEstado(id_auto, 0);
        }

        public Reserva ObtenerReserva(int id_usuario)
        {
            var list = dataAccess.ExecuteDataSet(String.Format("SELECT * FROM [Reserva] where [id_usuario]  = {0} and [fechaFin] IS NULL " , id_usuario));
            var _list = new List<Reserva>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Reserva reserva = new Reserva();
                reserva.id = (int)item["Id"];
                reserva.id_auto = (int)item["Id_auto"] ;
                _list.Add(reserva);
            }
            return _list.FirstOrDefault();
        }

        public void CambiarEstado(int id, int estado)
        {
            string _commandText = String.Format("UPDATE Auto SET Estado = {0} where id = {1}",estado, id);
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public void RegistrarReserva(int id)
        {            
            string _commandText = "INSERT INTO [dbo].[Reserva] ([id_auto] ,[id_usuario] ,[fechaInicio]) VALUES (" + id+ ", " + Session.GetInstance().usuario.Id + ",'"+ DataAccess.FechaHora() +  "')";
            dataAccess.ExecuteNonQuery(_commandText);
            CambiarEstado(id,1);
        }

        public bool ValidarReservasAnteriores()
        {
            var value = dataAccess.ExecuteScalar(
                    "SELECT "+
                    " CASE WHEN Fechafin  IS NULL AND [id_usuario] = " + Session.GetInstance().usuario.Id +
                    " THEN CAST(1 AS BIT) " +
                    " ELSE CAST(0 AS BIT) END AS TieneReserva " +
                    " FROM [Reserva] ORDER BY  ID DESC");
                
            if (value == null)
            {
                return false;
            }
            else
            {
                return (bool)value;
            }
        }

        public List<Reserva> Listar() 
        {
            var list = dataAccess.ExecuteDataSet("Reserva");
            var _list = new List<Reserva>();
            if (list.Tables[0].Rows.Count == 0)
            {
                return _list;
            }
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Reserva reserva = new Reserva();
                reserva.id = (int)item["Id"];
                reserva.id_auto = (int)item["Id_auto"];
                reserva.fechaFin = (DateTime)item["FechaInicio"];
                reserva.fechaInicio = (DateTime)item["FechaFin"];
                _list.Add(reserva);
            }
            return _list;
        }

        public List<Reserva> ListarPorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            string dateFormat = "yyyy-MM-dd";
            var list = dataAccess.ExecuteDataSet($"SELECT * FROM Reserva WHERE FECHAINICIO BETWEEN '{fechaInicio.ToString(dateFormat)}' AND '{fechaFin.ToString(dateFormat)}'");
            var _list = new List<Reserva>();
            if (list.Tables[0].Rows.Count == 0)
            {
                return _list;
            }
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Reserva reserva = new Reserva();
                reserva.id = (int)item["Id"];
                reserva.auto = autoService.ObtenerPorId((int)item["Id_auto"]);
                reserva.usuario = usuarioService.ObtenerPorId((int)item["Id_Usuario"]);
                reserva.fechaFin = (DateTime)item["FechaFin"];
                reserva.fechaInicio = (DateTime)item["FechaInicio"];
                _list.Add(reserva);
            }
            return _list;
        }
    }
}
