using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.Vehiculo;

namespace Campo_TPFinal_UI.Forms.Estacionamiento
{
    public partial class ABMEstacionamiento : Form, IIdiomaService
    {
        private readonly ITraductorService traductorService;
        private readonly IEstacionamientoService estacionamientoService;
        IDictionary<string, Traduccion> traducciones;
        int idEstacionamiento;


        public ABMEstacionamiento(ITraductorService traductorService, IEstacionamientoService estacionamientoService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            this.estacionamientoService = estacionamientoService;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            estacionamientoService.Crear(ubicacionTxt.Text ,int.Parse(espacioTxt.Text));
            Limpiar();
            Actualizar();
            MessageBox.Show(traducciones["textCreacion"].Texto, "OK");
        }

        private void ABMEstacionamiento_Load(object sender, EventArgs e)
        {
            Actualizar();
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir();

            lstEstacionamiento.RowHeadersVisible = false;
            lstEstacionamiento.AllowUserToAddRows = false;
            lstEstacionamiento.AllowUserToDeleteRows = false;
            lstEstacionamiento.EditMode = DataGridViewEditMode.EditProgrammatically;
            lstEstacionamiento.MultiSelect = false;
            lstEstacionamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Actualizar()
        {
            lstEstacionamiento.DataSource = estacionamientoService.Listar();
            lstEstacionamiento.Columns["id"].Visible = false;            
            lstEstacionamiento.Columns["ubicacion"].Width= 200;            
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(Lenguaje idioma = null)
        {
            traducciones = traductorService.ObtenerTraducciones(idioma);
            lstEstacionamiento.Columns["Ubicacion"].HeaderText = traducciones["lblUbicacion"].Texto;
            lstEstacionamiento.Columns["Espacios"].HeaderText = traducciones["lblEspacio"].Texto;

            lblUbicacion.Text = traducciones["lblUbicacion"].Texto;
            lblEspacio.Text = traducciones["lblEspacio"].Texto;
            btnCrear.Text = traducciones[btnCrear.Tag.ToString()].Texto;
            btnEditar.Text = traducciones[btnEditar.Tag.ToString()].Texto;
            btnBorrar.Text = traducciones[btnBorrar.Tag.ToString()].Texto;
            btnLimpiar.Text = traducciones[btnLimpiar.Tag.ToString()].Texto;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar() {

            ubicacionTxt.Text = "";
            espacioTxt.Text = "";
            idText.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estacionamientoService.Actualizar(idText.Text,ubicacionTxt.Text, int.Parse(espacioTxt.Text));
            Limpiar();
            Actualizar();
            MessageBox.Show(traducciones["txtUpdate"].Texto, "OK");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            estacionamientoService.Borrar(idEstacionamiento);
            Limpiar();
            Actualizar();
            MessageBox.Show(traducciones["txtDelete"].Texto, "OK");
        }

        private void lstEstacionamiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = lstEstacionamiento.SelectedRows[0].Cells[1].Value.ToString();
            var estacionamiento = estacionamientoService.ObtenerPorId(int.Parse(id));
            idText.Text = estacionamiento.Id.ToString();
            idEstacionamiento = estacionamiento.Id;
            ubicacionTxt.Text = estacionamiento.ubicacion;
            espacioTxt.Text = estacionamiento.espaciosTotal.ToString();
        }
    }
}
