using System.Data;

namespace Campo_TPFinal_DALContracts.Sistema.DB
{
    public interface IDataAccess
    {
        object ExecuteDataReader(string pCommandText);
        public DataSet ExecuteDataSet(string pCommandText);
        public int ExecuteNonQuery(string pCommandText);
        object ExecuteScalar(string pCommandText);
        DataSet SelectExecuteDataSet(string tabla);
        DataSet GetPorIdExecuteDataSet(string tabla, string id);
        int FirstRun(string pCommandText);
    }
}
