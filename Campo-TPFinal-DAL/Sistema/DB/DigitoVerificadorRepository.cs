using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL.Sistema.DB
{
    public class DigitoVerificadorRepository : IDigitoVerificadorRepository
    {
        private readonly IDataAccess dataAccess;

        public DigitoVerificadorRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void CalcularDigitoVerificadorHorizontal()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Usuario]");
            foreach (DataRow item in list.Tables[0].Rows)
            {
                var properties = "";
                for (int i = 0; i < item.ItemArray.Length - 1; i++)
                {
                    properties += item[i];
                    var dvh = CryptographyHelper.hash(properties);
                    string _commandText = $"UPDATE usuario SET dvh='{dvh.Replace("'", "\"")}' WHERE id='{item["id"]}'";
                    dataAccess.ExecuteNonQuery(_commandText);
                }
            }

        }
        public void CalcularDigitoVerificadorVertical()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [Usuario]");
            var properties = "";
            foreach (DataRow item in list.Tables[0].Rows)
            {
                for (int i = 0; i < item.ItemArray.Length - 1; i++)
                {
                    properties += item["dvh"];
                }
            }

            var dvh = CryptographyHelper.hash(properties);
            string _commandText = $"UPDATE dvv SET dvv='{dvh.Replace("'", "\"")}' WHERE tabla='usuario'";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public bool CheckDigitoVerificadorHorizontal() { return true; }

        public bool CheckDigitoVerificadorVertical() { return true; }

    }
}
