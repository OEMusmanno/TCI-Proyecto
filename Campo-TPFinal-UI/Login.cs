using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_DALContracts.Sistema.Idioma;

namespace Campo_TPFinal_UI
{
    public partial class Login : Form, IIdiomaService
    {
        private readonly MenuPrincipal MenuPrincipal;
        private readonly IBitacoraService bitacoraService;
        private readonly ILoginService loginService;
        private readonly ITraductorService traductorService;
        static Lenguaje lenguaje;


        public Login( MenuPrincipal menuPrincipal, IBitacoraService bitacoraService, ILoginService loginService, ITraductorService traductorService)
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
                if (ex.Message == "Se realizaron muchos intentos. Se cerrara el sistema")
                {
                    this.Close();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lenguaje = new Lenguaje { Nombre = "Español", id = 1 };
            bitacoraService.GuardarBitacora("se cambio el lenguaje a : " + lenguaje.Nombre);
            ActualizarLenguaje(lenguaje);
        }
        private void botonLenguaje1_Click(object sender, EventArgs e)
        {
            lenguaje = new Lenguaje { Nombre = "English", id = 2 };
            bitacoraService.GuardarBitacora("se cambio el lenguaje a : " + lenguaje.Nombre);
            ActualizarLenguaje(lenguaje);
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(Lenguaje idioma = null)
        {           
            var traducciones = traductorService.ObtenerTraducciones(idioma);          
                     
            LenguajeLabel.Text = traducciones[LenguajeLabel.Tag.ToString()].Texto;
            passwordLabel.Text = traducciones[passwordLabel.Tag.ToString()].Texto;
            userLabel.Text = traducciones[userLabel.Tag.ToString()].Texto;
            btnLogIn.Text = traducciones[btnLogIn.Tag.ToString()].Texto;

        }

    }
}
