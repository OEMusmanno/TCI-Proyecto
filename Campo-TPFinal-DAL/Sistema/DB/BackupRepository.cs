using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;

namespace Campo_TPFinal_DAL.Sistema.DB
{
    public class BackupRepository : IBackupRepository
    {	
		private readonly IDataAccess dataAccess;
		private readonly IBitacoraService bitacoraService;

		public BackupRepository(IDataAccess dataAccess, IBitacoraService bitacoraService)
        {
            this.dataAccess = dataAccess;
            this.bitacoraService = bitacoraService;
        }

        public BackupRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public bool backUp(string path)
		{
			try
			{
				string dateFormat = "yyyy-MM-dd-HH-mm-ss";
				string bkpPath = path + "\\bkp" + DateTime.Now.ToString(dateFormat) + ".bak";
				string _commandText = "BACKUP DATABASE Campo TO  DISK = '" + bkpPath + "'";
				File.Delete(bkpPath);
				dataAccess.ExecuteNonQuery(_commandText);		

				return true;
			}
			catch (Exception e)
			{
				string message = EnumBitacora.Backup.ToString() + ":" + e.Message ;
				bitacoraService.GuardarBitacora(message, "Alto");;
				return false;
			}
		}

		public bool restore(string path)
		{
			try
			{
				string singleUser = "ALTER DATABASE Campo SET Single_User WITH Rollback Immediate";
				string query = $"USE master; RESTORE DATABASE Campo FROM DISK = '{path}' WITH REPLACE;";
				string multiUser = "ALTER DATABASE Campo SET Multi_User";
				dataAccess.ExecuteNonQuery(singleUser);
				dataAccess.ExecuteNonQuery(query);
				dataAccess.ExecuteNonQuery(multiUser);
				return true;
			}
			catch (Exception e)
			{
				string message = EnumBitacora.Restore.ToString() + ":" + e.Message;
				bitacoraService.GuardarBitacora(message, "Alto"); ;
				return false;
			}
		}

        public bool PrimeraEjecucion(string path)
        {
            try
            {
				string code = "CREATE DATABASE [Campo]";
                string singleUser = "ALTER DATABASE Campo SET Single_User WITH Rollback Immediate";
                string query = $"USE master; RESTORE DATABASE Campo FROM DISK = '{path}' WITH REPLACE;";
                string multiUser = "ALTER DATABASE Campo SET Multi_User";
                dataAccess.FirstRun(code);
                dataAccess.ExecuteNonQuery(singleUser);
                dataAccess.ExecuteNonQuery(query);
                dataAccess.ExecuteNonQuery(multiUser);
                return true;
            }
            catch (Exception e)
            {
                string message = EnumBitacora.Restore.ToString() + ":" + e.Message;
                bitacoraService.GuardarBitacora(message, "Alto"); ;
                return false;
            }
        }
    }
}
