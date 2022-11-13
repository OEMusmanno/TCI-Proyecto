using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DAL.Sistema.DB;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL.Sistema.DB
{
    public class DigitoVerificadorRepository : IDigitoVerificadorRepository
    {
        private readonly IDataAccess dataAccess;
        private readonly IUsuarioRepository usuarioRepository;


        public DigitoVerificadorRepository(IDataAccess dataAccess, IUsuarioRepository usuarioRepository)
        {
            this.dataAccess = dataAccess;
            this.usuarioRepository = usuarioRepository;
        }

        public void CalcularDigitoVerificadorHorizontal()
        {
            var list = usuarioRepository.Listar();
            foreach (Usuario DataUsuario in list)
            {
                var digito = CalculoDvh(DataUsuario);
                usuarioRepository.ActualizarDvh(DataUsuario.Id , digito);                
            }
        }

        private string CalculoDvh(Usuario DataUsuario)
        {
            Type t = DataUsuario.GetType();
            string dvh = string.Empty;
            var props = t.GetProperties();
            foreach (var propiedad in props)
            {
                if (propiedad.PropertyType.FullName.Equals(typeof(DateTime).FullName))
                {
                    DateTime a = (DateTime)propiedad.GetValue(DataUsuario);
                    dvh += a.ToString("ddmmyyyyhhmmss");
                }
                else
                {
                    dvh += propiedad.GetValue(DataUsuario).ToString();
                }
            }
            return GetMd5Hash(dvh);
        }

        static string GetMd5Hash(string input)
        {
            StringBuilder sBuilder = new StringBuilder();
            using (var md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
            }
            return sBuilder.ToString();
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
            var digito = GetMd5Hash(properties);
            string _commandText = $"UPDATE dvv SET dvv='{digito}' WHERE tabla='usuario'";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public bool CheckDigitoVerificadorHorizontal()
        {
            var list = usuarioRepository.Listar();
            var listadoDvh = usuarioRepository.ListarDvh();
            foreach (Usuario DataUsuario in list)
            {
                var digito = CalculoDvh(DataUsuario);
                var discrepancy = listadoDvh.Exists(x => x == digito);
                if (!discrepancy) return false;
            }
            return true;         
        }

        public bool CheckDigitoVerificadorVertical()
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
            var digito = GetMd5Hash(properties);
            bool discrepancy = false;

            var data = dataAccess.SelectExecuteDataSet("dvv");
            foreach (DataRow item in data.Tables[0].Rows)
            {
                for (int i = 0; i < item.ItemArray.Length - 1; i++)
                {
                    discrepancy = digito != item["dvv"].ToString();
                }
            }
            return !discrepancy;

        }

    }
}
