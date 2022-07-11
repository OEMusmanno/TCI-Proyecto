using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_UI.Forms.Idioma;

namespace Campo_TPFinal_UI
{
    public partial class MenuPrincipal : Form, IIdiomaService
    {
        private readonly RegistrarAlquiler registrarAlquiler;
        private readonly AplicarPenalidad aplicarPenalidad;
        private readonly AdministracionDeUsuarios administrarUsuarios;
        private readonly AdministracionPerfiles administracionPerfiles;
        private readonly IBitacoraService bitacoraService;
        private readonly ITraductorService traductorService;
        private readonly CambioIdioma cambioIdioma;
        private readonly GestionIdioma gestionIdioma;


        public MenuPrincipal(
            IBitacoraService bitacoraService,
            RegistrarAlquiler registrarAlquiler,
            AplicarPenalidad aplicarPenalidad,
            ITraductorService traductorService,
            AdministracionDeUsuarios administrarUsuarios,
            AdministracionPerfiles administracionPerfiles,
            CambioIdioma cambioIdioma,
            GestionIdioma gestionIdioma)
        {
            this.bitacoraService = bitacoraService;
            this.registrarAlquiler = registrarAlquiler;
            this.aplicarPenalidad = aplicarPenalidad;
            this.traductorService = traductorService;
            this.administrarUsuarios = administrarUsuarios;
            this.administracionPerfiles = administracionPerfiles;

            InitializeComponent();
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default
            this.cambioIdioma = cambioIdioma;
            this.gestionIdioma = gestionIdioma;

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
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = aplicarPenalidad;
            bitacoraService.GuardarBitacoraDefault("Ingreso a Penalidades");
            form1.ShowDialog();
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }
        private void Traducir(Lenguaje idioma = null)
        {

            Session.traducciones = traductorService.ObtenerTraducciones(idioma);
            btnAlquilar.Text = Session.traducciones[btnAlquilar.Tag.ToString()].Texto;
            btnPerfil.Text = Session.traducciones[btnPerfil.Tag.ToString()].Texto;
            btnSalir.Text = Session.traducciones[btnSalir.Tag.ToString()].Texto;
            btnUsuarios.Text = Session.traducciones[btnUsuarios.Tag.ToString()].Texto;
            btnGestionIdioma.Text = Session.traducciones[btnGestionIdioma.Tag.ToString()].Texto;
            LenguajeLabel.Text = Session.traducciones[LenguajeLabel.Tag.ToString()].Texto;

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Session.GetInstance().usuario.alias;
            var user = Session.GetInstance().usuario.rol;
            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("administrador"))
            {
                btnPerfil.Visible = true;
                btnUsuarios.Visible = true;
                btnGestionIdioma.Visible = true;
            }
            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("alquilar"))
            {
                btnAlquilar.Enabled = true;
            }
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default
            Session.SuscribirObservador(this);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var form1 = administrarUsuarios;
            bitacoraService.GuardarBitacoraDefault("Ingreso a administracion de Usuarios");
            form1.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                var form1 = administracionPerfiles;
                bitacoraService.GuardarBitacoraDefault("Ingreso a administracion de Usuarios");
                form1.ShowDialog();
            }
            catch
            {

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LenguajeLabel_Click(object sender, EventArgs e)
        {
            cambioIdioma.ShowDialog();
        }

        private void btnGestionIdioma_Click(object sender, EventArgs e)
        {
            gestionIdioma.ShowDialog();
        }
    }
}
