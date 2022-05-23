using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;

namespace Campo_TPFinal_UI
{
    public partial class MenuPrincipal : Form
    {
        private readonly RegistrarAlquiler registrarAlquiler;
        private readonly AplicarPenalidad aplicarPenalidad;
        private readonly IBitacoraService bitacoraService;

        public MenuPrincipal(IBitacoraService bitacoraService, RegistrarAlquiler registrarAlquiler, AplicarPenalidad aplicarPenalidad)
        {
            InitializeComponent();
            this.bitacoraService = bitacoraService;
            this.registrarAlquiler = registrarAlquiler;
            this.aplicarPenalidad = aplicarPenalidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = registrarAlquiler;
            bitacoraService.GuardarBitacoraDefault("Ingreso a registrar alquiler");
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

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = aplicarPenalidad;
            bitacoraService.GuardarBitacoraDefault("Ingreso a Penalidades");
            form1.ShowDialog();
        }
    }
}
