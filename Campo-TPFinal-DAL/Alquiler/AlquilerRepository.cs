using Campo_TPFinal_BE.Alquiler;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
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

        public void FinalizarReserva()
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss.FFF";
            dataAccess.ExecuteNonQuery("UPDATE [dbo].[Reserva] SET [fechaFin] = '" + fechaHora.ToString(format)+"'");
        }

        public Reserva ObtenerReserva(int id_usuario)
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [Reserva] where [id_usuario] = " + id_usuario);
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
    

        public void RegistrarReserva(int id)
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss.FFF";
            string _commandText = "INSERT INTO [dbo].[Reserva] ([id_auto] ,[id_usuario] ,[fechaInicio]) VALUES (" + id+ ", " + Session.GetInstance().usuario.Id + ",'"+ fechaHora.ToString(format) +  "')";
            dataAccess.ExecuteNonQuery(_commandText);
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
