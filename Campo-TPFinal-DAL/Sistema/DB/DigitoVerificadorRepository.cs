using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
                    string _commandText = $"UPDATE usuario SET dvh='{properties}' WHERE id='{item["id"]}'";
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

            string _commandText = $"UPDATE dvv SET dvv='{properties}' WHERE tabla='usuario'";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public bool CheckDigitoVerificadorHorizontal()
        {
            var dvh = "";
            string properties = "";
            var data = dataAccess.ExecuteDataSet("SELECT * FROM [Usuario]");
            foreach (DataRow item in data.Tables[0].Rows)
            {
                for (int i = 0; i < item.ItemArray.Length - 1; i++)
                {
                    properties += item[i];
                    dvh = CryptographyHelper.hash(properties);
                }
                var discrepancy = properties != item["dvh"].ToString();
                if (discrepancy) return true;
            }
            return true;         
        }

        public bool CheckDigitoVerificadorVertical()
        {
            var result = "";
            var discrepancy = false;
            var data = dataAccess.ExecuteDataSet("SELECT * FROM [Usuario]");
            foreach (DataRow item in data.Tables[0].Rows)
            {
                for (int i = 0; i < item.ItemArray.Length - 1; i++)
                {
                    result += item["dvh"];
                }
            }

            data = dataAccess.ExecuteDataSet($"SELECT * FROM dvv WHERE tabla='usuario'");
            foreach (DataRow item in data.Tables[0].Rows)
            {
                for (int i = 0; i < item.ItemArray.Length - 1; i++)
                {
                    discrepancy = (result.Replace("'", "\"") != item["dvv"].ToString());
                }
            }
            return discrepancy;
        }

    }
}
