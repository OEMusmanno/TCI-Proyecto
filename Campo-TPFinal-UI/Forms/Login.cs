using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_DALContracts.Sistema.Idioma;
using Campo_TPFinal_UI.Forms.Idioma;

namespace Campo_TPFinal_UI
{
    public partial class Login : Form, IIdiomaService
    {
        private readonly MenuPrincipal MenuPrincipal;
        private readonly IBitacoraService bitacoraService;
        private readonly ILoginService loginService;
        private readonly ITraductorService traductorService;
        private readonly CambioIdioma cambioIdioma;
        static Lenguaje lenguaje;


        public Login(MenuPrincipal menuPrincipal, IBitacoraService bitacoraService, ILoginService loginService, ITraductorService traductorService, CambioIdioma cambioIdioma)
        {
            this.MenuPrincipal = menuPrincipal;
            this.bitacoraService = bitacoraService;
            this.loginService = loginService;
            this.traductorService = traductorService;
            InitializeComponent();
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default
            Session.SuscribirObservador(this);
            this.cambioIdioma = cambioIdioma;
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            try
            {
                loginService.Login(txtUser.Text, txtPass.Text);
                var form1 = MenuPrincipal;
                this.Hide();
                Session.GetInstance().usuario.idioma = lenguaje;
                form1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bitacoraService.GuardarBitacora(ex.Message);
                if (ex.Message == Session.traducciones["Error3Intento"].Texto)
                {
                    this.Close();
                    Application.Exit();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambioIdioma.ShowDialog();           
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(Lenguaje idioma = null)
        {
            LenguajeLabel.Text = Session.traducciones[LenguajeLabel.Tag.ToString()].Texto;
            passwordLabel.Text = Session.traducciones[passwordLabel.Tag.ToString()].Texto;
            userLabel.Text = Session.traducciones[userLabel.Tag.ToString()].Texto;
            btnLogIn.Text = Session.traducciones[btnLogIn.Tag.ToString()].Texto;

        }

    }
}
