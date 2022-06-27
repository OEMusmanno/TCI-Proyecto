using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.Sistema.Idioma
{
    public interface ILoginService
    {
        void Login(string user, string pass);
    }
}
