using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts.Sistema.DB
{
    public interface IBackupRepository
    {
        bool backUp(string path);
        bool PrimeraEjecucion(string path);
        bool restore(string nombreArchivo);
    }
}
