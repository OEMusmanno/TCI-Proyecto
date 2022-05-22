using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;

namespace Campo_TPFinal_UI
{
    public partial class MenuPrincipal : Form
    {
        private readonly RegistrarAlquiler _registrarAlquiler;
        private readonly IBitacoraService bitacoraService;

        public MenuPrincipal(IBitacoraService bitacoraService, RegistrarAlquiler registrarAlquiler)
        {
            InitializeComponent();
            this.bitacoraService = bitacoraService;
            _registrarAlquiler = registrarAlquiler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = _registrarAlquiler;
            bitacoraService.GuardarBitacoraDefault("ingreso a registrar alquiler");
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bitacoraService.GuardarBitacoraDefault("Log out");
            Session.CloseSession();
            this.Close();
        }
    }
}
