using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Alquiler;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;

namespace Campo_TPFinal_UI
{
    public partial class RegistrarAlquiler : Form, IIdiomaService
    {
        private readonly IAutoService autoService;
        private readonly IAlquilerService alquilerService;

        private readonly ITraductorService traductorService;
        public RegistrarAlquiler(IAutoService autoBLL, IAlquilerService alquilerService, ITraductorService traductorService)
        {
            this.autoService = autoBLL;
            InitializeComponent();
            this.alquilerService = alquilerService;
            this.traductorService = traductorService;
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }
        private void Traducir(Lenguaje idioma = null)
        {
            var traducciones = traductorService.ObtenerTraducciones(idioma);

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
                brnFinalizar.Enabled = true; btnAlquilar.Enabled = false;
                var reserva = alquilerService.obtenerAlquiler();
                lblMarca1.Text = reserva.auto.Marca;
                lblModelo1.Text = reserva.auto.Modelo;
                lblTipoVehiculo1.Text = reserva.auto.tipoVehiculo.Nombre;
            }
            else
            {
                lblMarca1.Text = "-";
                lblModelo1.Text = "-";
                lblTipoVehiculo1.Text = "-";
                brnFinalizar.Enabled = false;
                btnAlquilar.Enabled = true;
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
                MessageBox.Show("Se registro correctamente la reserva", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RegistrarAlquiler_Load(object sender, EventArgs e)
        {
            grdListadoAutos.Columns.Clear();
            grdListadoAutos.Columns.Add("id", "id");
            grdListadoAutos.Columns["Id"].Visible = false;
            grdListadoAutos.Columns.Add("Marca", "Marca");
            grdListadoAutos.Columns["Marca"].Tag = "lblMarca";
            grdListadoAutos.Columns.Add("Modelo", "Modelo");
            grdListadoAutos.Columns["Modelo"].Tag = "lblModelo";
            grdListadoAutos.Columns.Add("Ubicacion", "Ubicacion");
            grdListadoAutos.Columns["Ubicacion"].Tag = "lblUbicacion";
            grdListadoAutos.Columns["Ubicacion"].Width = 200;
            grdListadoAutos.Columns.Add("TipoVehiculo", "Tipo Vehiculo");
            grdListadoAutos.Columns["TipoVehiculo"].Tag = "lblTipoVehiculo";
            grdListadoAutos.Columns.Add("MinutoRecorrido", "Minuto Recorrido");
            grdListadoAutos.Columns["MinutoRecorrido"].Tag = "lblMinuto";
            grdListadoAutos.Columns["MinutoRecorrido"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("MinutoDetenido", "Minuto Detenido");
            grdListadoAutos.Columns["MinutoDetenido"].Tag = "lblMinutoDetenido";
            grdListadoAutos.Columns["MinutoDetenido"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("PrecioDia", "Precio Dia");
            grdListadoAutos.Columns["PrecioDia"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("PrecioHora", "Precio Hora");
            grdListadoAutos.Columns["PrecioHora"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("PrecioKmExtra", "Precio Km Extra");
            grdListadoAutos.Columns["PrecioKmExtra"].DefaultCellStyle.Format = "c";
            grdListadoAutos.RowHeadersVisible = false;
            grdListadoAutos.AllowUserToAddRows = false;
            grdListadoAutos.AllowUserToDeleteRows = false;
            grdListadoAutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdListadoAutos.MultiSelect = false;
            grdListadoAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default

            Actualizar();
        }

        private void brnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {

                alquilerService.FinalizarReserva();
                Actualizar();
                MessageBox.Show("Finalizo la Reserva", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}