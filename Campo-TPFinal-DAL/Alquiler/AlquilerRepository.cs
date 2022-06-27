using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DALContracts.Alquiler;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System;
using System.Collections.Generic;
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
