using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_DAL.Sistema.DB;
using Campo_TPFinal_DALContracts.Sistema.DB;
using Campo_TPFinal_UI.Forms.Estacionamiento;
using Campo_TPFinal_UI.Forms.Idioma;
using Campo_TPFinal_UI.Forms.Negocio;
using Campo_TPFinal_UI.Forms.Sistema;
using Campo_TPFinal_UI.Forms.SolicitudDeCompra;

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
        private readonly IBackupService backup;
        private readonly CambioIdioma cambioIdioma;
        private readonly GestionIdioma gestionIdioma;
        private readonly Bitacora bitacora;
        private readonly ControlCambios controlCambios;
        private readonly ABMEstacionamiento aBMEstacionamiento;
        private readonly ABMAuto aBMAuto;
        private readonly RevisionDeCompra  revisionDeCompra;
        private readonly Reporte reporte;


        public MenuPrincipal(
            IBitacoraService bitacoraService,
            RegistrarAlquiler registrarAlquiler,
            AplicarPenalidad aplicarPenalidad,
            ITraductorService traductorService,
            AdministracionDeUsuarios administrarUsuarios,
            AdministracionPerfiles administracionPerfiles,
            CambioIdioma cambioIdioma,
            GestionIdioma gestionIdioma,
            IBackupService backup,
            Bitacora bitacora,
            ControlCambios controlCambios,
            ABMEstacionamiento aBMEstacionamiento,
            ABMAuto aBMAuto,
            RevisionDeCompra revisionDeCompra,
            Reporte reporte)
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
            this.backup = backup;
            this.bitacora = bitacora;
            this.controlCambios = controlCambios;
            this.aBMEstacionamiento = aBMEstacionamiento;
            this.aBMAuto = aBMAuto;
            this.revisionDeCompra = revisionDeCompra;
            this.reporte = reporte;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = registrarAlquiler;
            bitacoraService.GuardarBitacora("Ingreso a registrar alquiler", "Bajo");
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bitacoraService.GuardarBitacora("Log out", "Bajo");
            Session.CloseSession();
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = aplicarPenalidad;
            bitacoraService.GuardarBitacora("Ingreso a Penalidades", "Bajo");
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
            btnGestionAuto.Text = Session.traducciones[btnGestionAuto.Tag.ToString()].Texto;
            btnEstacionamiento.Text = Session.traducciones[btnEstacionamiento.Tag.ToString()].Texto;
            btnGestionIdioma.Text = Session.traducciones[btnGestionIdioma.Tag.ToString()].Texto;
            LenguajeLabel.Text = Session.traducciones[LenguajeLabel.Tag.ToString()].Texto;
            btnCompra.Text = Session.traducciones[btnCompra.Tag.ToString()].Texto;            
            btnReporte.Text = Session.traducciones[btnReporte.Tag.ToString()].Texto;

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Session.GetInstance().usuario.alias;
            var user = Session.GetInstance().usuario.rol;
            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("administrador"))
            {
                btnCompra.Visible = true;
                btnPerfil.Visible = true;
                btnUsuarios.Visible = true;
                btnGestionIdioma.Visible = true;
                btnRestore.Visible = true;
                btnBackup.Visible = true;
                btnLog.Visible = true;
                btnControlCambios.Visible = true;
                btnEstacionamiento.Visible = true;
                btnGestionAuto.Visible = true;
                btnReporte.Visible = true;
            }
            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("contador"))
            {
                btnCompra.Visible = true;
                btnReporte.Visible = true;
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
            bitacoraService.GuardarBitacora("Ingreso a administracion de Usuarios", "Alto");
            form1.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                var form1 = administracionPerfiles;
                bitacoraService.GuardarBitacora("Ingreso a administracion de Usuarios", "Alto");
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

        private void Backup_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            folder.ShowDialog();
            backup.Backup(folder.SelectedPath);
            MessageBox.Show(Session.traducciones["BackupRegistrado"].Texto, "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            var openFolder = new OpenFileDialog
            {
                Filter = "Database backups (*.bak)|*.bak",
                Title = "Open database backup"
            };
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                backup.Restore(openFolder.FileName);
            }
            this.UseWaitCursor = true;
            MessageBox.Show(Session.traducciones["RestoreCompletado"].Texto, "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.UseWaitCursor = false;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            bitacora.ShowDialog();
        }

        private void btnControlCambios_Click(object sender, EventArgs e)
        {
            controlCambios.ShowDialog();
        }

        private void btnEstacionamiento_Click(object sender, EventArgs e)
        {
            aBMEstacionamiento.ShowDialog();
        }

        private void btnGestionAuto_Click(object sender, EventArgs e)
        {
            aBMAuto.ShowDialog();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            revisionDeCompra.ShowDialog();            
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            reporte.ShowDialog();
        }

        private void btnSerializacion_Click(object sender, EventArgs e)
        {

        }
    }
}
