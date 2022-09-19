using Campo_TPFinal_BLLContracts.Sistema;
using Campo_TPFinal_DALContracts.Sistema.DB;

namespace Campo_TPFinal_BLL.Sistema
{
    public  class BackupService: IBackupService
    {
        private readonly IBackupRepository backupRepository ;

        public BackupService(IBackupRepository backupRepository)
        {
            this.backupRepository = backupRepository;
        }

        public void Backup(string path) {
            backupRepository.backUp(path);
        }

        public void Restore( string nombreDeArchivo)
        {
            backupRepository.restore(nombreDeArchivo);
        }

        public void FirstRun() {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "Backups");
        }

    }
}
