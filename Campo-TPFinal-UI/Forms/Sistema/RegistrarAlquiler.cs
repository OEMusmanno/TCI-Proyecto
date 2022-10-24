using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts.Alquiler;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.Vehiculo;

namespace Campo_TPFinal_UI
{
    public partial class RegistrarAlquiler : Form, IIdiomaService
    {
        private readonly IAutoService autoService;
        private readonly IAlquilerService alquilerService;
        private readonly ITraductorService traductorService;
        IDictionary<string, Traduccion> traducciones;

        public RegistrarAlquiler(IAutoService autoBLL, IAlquilerService alquilerService, ITraductorService traductorService)
        {
            this.autoService = autoBLL;
            this.alquilerService = alquilerService;
            this.traductorService = traductorService;
            InitializeComponent();
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }
        private void Traducir(Lenguaje idioma = null)
        {
            traducciones = traductorService.ObtenerTraducciones(idioma);

            btnAlquilar.Text = traducciones[btnAlquilar.Tag.ToString()].Texto;
            lblAlquiler.Text = traducciones[lblAlquiler.Tag.ToString()].Texto;
            brnFinalizar.Text = traducciones[brnFinalizar.Tag.ToString()].Texto;
            grpAlquiler.Text = traducciones[grpAlquiler.Tag.ToString()].Texto;
            lblMarca.Text = traducciones[lblMarca.Tag.ToString()].Texto;
            lblModelo.Text = traducciones[lblModelo.Tag.ToString()].Texto;
            lblTipoVehiculo.Text = traducciones[lblTipoVehiculo.Tag.ToString()].Texto;

        }
        private void Actualizar()
        {
            grdListadoAutos.Rows.Clear();
            foreach (Auto auto in autoService.Listar())
            {
                grdListadoAutos.Rows.Add(
                    auto.Id
                    , auto.Marca
                    , auto.Modelo
                    , auto.Estacionamiento.ubicacion
                    , auto.tipoVehiculo.Nombre
                    , auto.tipoVehiculo.MinutoRecorrido
                    , auto.tipoVehiculo.MinutoDetenido
                    , auto.tipoVehiculo.PrecioDia
                    , auto.tipoVehiculo.PrecioHora
                    , auto.tipoVehiculo.PrecioKmExtra
                    );
            }

            if (alquilerService.validarReservasAnteriores())
            {
                grdListadoAutos.Visible = false;
                btnAlquilar.Visible = false;
                lblAlquiler.Visible = false;

                grpAlquiler.Visible = true;
                brnFinalizar.Visible = true; 
                lblMarca.Visible = true;
                lblMarca1.Visible = true;
                lblModelo1.Visible = true;
                lblTipoVehiculo.Visible = true;
                lblTipoVehiculo1.Visible = true;
                var reserva = alquilerService.obtenerAlquiler();
                lblMarca1.Text = reserva.auto.Marca;
                lblModelo1.Text = reserva.auto.Modelo;
                lblTipoVehiculo1.Text = reserva.auto.tipoVehiculo.Nombre;
            }
            else
            {
                grpAlquiler.Visible = false;
                lblMarca1.Visible = false;
                lblModelo1.Visible = false;
                lblTipoVehiculo1.Visible = false;
                lblMarca.Visible = false;
                lblTipoVehiculo.Visible = false;
                brnFinalizar.Visible = false;
                btnAlquilar.Visible = true;
                lblAlquiler.Visible = true;
                grdListadoAutos.Visible = true;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(grdListadoAutos.SelectedRows[0].Cells[0].Value.ToString());
                var Marca = grdListadoAutos.SelectedRows[0].Cells[1].Value.ToString();
                var Modelo = grdListadoAutos.SelectedRows[0].Cells[2].Value.ToString();
                alquilerService.RegistrarReserva(Id, Marca, Modelo);
                Actualizar();
                MessageBox.Show(traducciones["ReservaRegistrada"].Texto, "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RegistrarAlquiler_Load(object sender, EventArgs e)
        {
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default
            grdListadoAutos.Columns.Clear();
            grdListadoAutos.Columns.Add("id", "id");
            grdListadoAutos.Columns["Id"].Visible = false;
            grdListadoAutos.Columns.Add("Marca", traducciones["lblMarca"].Texto);
            grdListadoAutos.Columns.Add("Modelo", traducciones["lblModelo"].Texto);
            grdListadoAutos.Columns.Add("Ubicacion", traducciones["lblUbicacion"].Texto);
            grdListadoAutos.Columns["Ubicacion"].Width = 200;
            grdListadoAutos.Columns.Add("TipoVehiculo", traducciones["lblTipoVehiculo"].Texto);
            grdListadoAutos.Columns.Add("MinutoRecorrido", traducciones["lblMinuto"].Texto);
            grdListadoAutos.Columns["MinutoRecorrido"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("MinutoDetenido", traducciones["lblMinutoDetenido"].Texto);
            grdListadoAutos.Columns["MinutoDetenido"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("PrecioDia", traducciones["lblPrecioDia"].Texto);
            grdListadoAutos.Columns["PrecioDia"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("PrecioHora", traducciones["lblPrecioHora"].Texto);
            grdListadoAutos.Columns["PrecioHora"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("PrecioKmExtra", traducciones["lblPrecioKm"].Texto);
            grdListadoAutos.Columns["PrecioKmExtra"].DefaultCellStyle.Format = "c";
            grdListadoAutos.RowHeadersVisible = false;
            grdListadoAutos.AllowUserToAddRows = false;
            grdListadoAutos.AllowUserToDeleteRows = false;
            grdListadoAutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdListadoAutos.MultiSelect = false;
            grdListadoAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

         
            Session.SuscribirObservador(this);
            Actualizar();
        }

        private void brnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = alquilerService.obtenerAlquiler().auto.Id; 
                alquilerService.FinalizarReserva(Id);
                Actualizar();
                MessageBox.Show(traducciones["ReservaFinalizada"].Texto, "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}