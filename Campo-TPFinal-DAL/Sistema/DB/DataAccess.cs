using Campo_TPFinal_BE.Solicitud;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL.Sistema.DB
{
    public class DataAccess : IDataAccess
    {
        SqlConnection mCon = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);

        public static string FechaHora()
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss.FFF";
            return fechaHora.ToString(format);
        }

        public DataSet ExecuteDataSet(string pCommandText)
        {
            try
            {
                SqlDataAdapter mDa = new SqlDataAdapter(pCommandText, mCon);
                DataSet mDs = new DataSet();

                mDa.Fill(mDs);

                return mDs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }

        }

        public DataSet SelectExecuteDataSet(string tabla)
        {
            var pCommandText = $"SELECT * FROM [{tabla}]";
            return ExecuteDataSet(pCommandText);
        }

        public DataSet GetPorIdExecuteDataSet(string tabla, string id)
        {
            var pCommandText = $"SELECT * FROM [{tabla}] where id = {id}";
            return ExecuteDataSet(pCommandText);
        }

        public int ExecuteNonQuery(string pCommandText)
        {
            using (SqlCommand mCom = new SqlCommand(pCommandText, mCon))
            {
                try
                {                    
                    mCon.Open();
                    return mCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (mCon.State != ConnectionState.Closed)
                        mCon.Close();
                }
            }
           
        }        

        public int DeleteExecuteNonQuery(string table, string id)
        {
            string _commandText = $"DELETE * FROM {table} where id = {id}";

            using (SqlCommand mCom = new SqlCommand(_commandText, mCon))
            {
                try
                {
                    mCon.Open();
                    return mCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (mCon.State != ConnectionState.Closed)
                        mCon.Close();
                }
            }
        }

        public object ExecuteDataReader(string pCommandText)
        {
            try
            {
                SqlCommand mCom = new SqlCommand(pCommandText, mCon);
                mCon.Open();
                return mCom.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }
        }

        public object ExecuteScalar(string pCommandText)
        {
            try
            {
                SqlCommand mCom = new SqlCommand(pCommandText, mCon);
                mCon.Open();
                return mCom.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }
        }
    }
}
