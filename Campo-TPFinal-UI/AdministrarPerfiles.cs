using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BLLContracts.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campo_TPFinal_UI
{
    public partial class AdministrarPerfiles : Form, IIdiomaService
    {
        public AdministrarPerfiles()
        {
            InitializeComponent();
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            throw new NotImplementedException();
        }

        private void AdministrarPerfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
