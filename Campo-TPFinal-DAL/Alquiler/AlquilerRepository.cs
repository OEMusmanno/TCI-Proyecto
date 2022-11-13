using Campo_TPFinal_BE.Alquiler;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
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

        public AlquilerRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
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
    }


}
