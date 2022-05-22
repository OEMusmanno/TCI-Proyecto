using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;

namespace Campo_TPFinal_UI
{
    public partial class Login : Form
    {
        private readonly LogManager logManager;
        private readonly MenuPrincipal MenuPrincipal;
        private readonly IBitacoraService bitacoraService;

        public Login(LogManager logManager, MenuPrincipal menuPrincipal, IBitacoraService bitacoraService)
        {
            this.logManager = logManager;
            this.MenuPrincipal = menuPrincipal;
            InitializeComponent();
            this.bitacoraService = bitacoraService;
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (logManager.log(txtUser.Text, txtPass.Text))
            {
                var form1 = MenuPrincipal;
                bitacoraService.GuardarBitacoraDefault("Log in");
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
