using System.Data;

namespace Campo_TPFinal_DALContracts.Sistema.DB
{
    public interface IDataAccess
    {
        public DataSet ExecuteDataSet(string pCommandText);

        public int ExecuteNonQuery(string pCommandText);
        object ExecuteScalar(string pCommandText);
    }
}
