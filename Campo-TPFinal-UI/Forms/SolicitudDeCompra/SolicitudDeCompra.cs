using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Solicitud;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLL.Vehiculo;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.SolicitudDeCompra;
using Campo_TPFinal_BLLContracts.Vehiculo;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Campo_TPFinal_UI.Forms.SolicitudDeCompra
{
    public partial class SolicitudDeCompra : Form, IIdiomaService
    {

        private readonly ITraductorService traductorService;
        private readonly ITipoVehiculoService tipoVehiculoService;
        private readonly ISolicitudDeCompraService solicitudDeCompraService;
        IDictionary<string, Traduccion> traducciones;
        SolicitudCompra solicitudDeCompra;
        double Total;

        public SolicitudDeCompra(ITraductorService traductorService, ITipoVehiculoService tipoVehiculoService, ISolicitudDeCompraService solicitudDeCompraService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            this.tipoVehiculoService = tipoVehiculoService;
            this.solicitudDeCompraService = solicitudDeCompraService;
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void SolicitudDeCompra_Load(object sender, EventArgs e)
        {
            Total = 0;
            solicitudDeCompra = new SolicitudCompra();
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir();
            Actualizar();

            grdSolicitud.RowHeadersVisible = false;
            grdSolicitud.AllowUserToAddRows = false;
            grdSolicitud.AllowUserToDeleteRows = false;
            grdSolicitud.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdSolicitud.MultiSelect = false;
            grdSolicitud.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Actualizar()
        {
            grdSolicitud.DataSource = "";
            grdSolicitud.DataSource = solicitudDeCompra.itemDeCompras;
            cmbTipo.DataSource = tipoVehiculoService.Listar();
            cmbTipoCambio.DataSource = Enum.GetValues(typeof(TipoCambio));
            cmbTipoPago.DataSource = Enum.GetValues(typeof(TipoPago));

            grdSolicitud.Columns["Id"].Visible = false;
            grdSolicitud.Columns["Marca"].HeaderText = traducciones["lblMarca"].Texto;
            grdSolicitud.Columns["Modelo"].HeaderText = traducciones["lblModelo"].Texto;
            grdSolicitud.Columns["TipoVehiculo"].HeaderText = traducciones["lblTipoVehiculo"].Texto;
            grdSolicitud.Columns["cantidad"].HeaderText = traducciones["txtCantidad"].Texto;
            grdSolicitud.Columns["PrecioUnitario"].HeaderText = traducciones["txtPrecioUnitario"].Texto;
            grdSolicitud.Columns["PrecioUnitario"].DefaultCellStyle.Format = "c";
            grdSolicitud.Columns["subtotal"].HeaderText = "Subtotal";
            grdSolicitud.Columns["subtotal"].DefaultCellStyle.Format = "c";
            grdSolicitud.Columns["TipoCambio"].HeaderText = traducciones["txtTipoCambio"].Texto;
            grdSolicitud.Columns["TipoPago"].HeaderText = traducciones["txtTipoPago"].Texto;
            txtTotal.Text = Total.ToString("C", CultureInfo.CurrentCulture);

            MarcaTxt.Text = "";
            modeloTxt.Text= "";
            cantidadText.Text = "";
            precioUnitarioText.Text = "";

        }
        private void Traducir(Lenguaje idioma = null)
        {
            traducciones = traductorService.ObtenerTraducciones(idioma);


            lblMarca.Text = traducciones["lblMarca"].Texto;
            lblModelo.Text = traducciones["lblModelo"].Texto;
            lblTipoVehiculo.Text = traducciones["lblTipoVehiculo"].Texto;
            txtPrecioUnitario.Text = traducciones["txtPrecioUnitario"].Texto;
            txtCantidad.Text = traducciones["txtCantidad"].Texto;
            txtTipoCambio.Text = traducciones["txtTipoCambio"].Texto;
            txtTipoPago.Text = traducciones["txtTipoPago"].Texto;
            btnSolicitar.Text = traducciones[btnSolicitar.Tag.ToString()].Texto;
            btnCancelar.Text = traducciones[btnCancelar.Tag.ToString()].Texto;
            txtAgregar.Text = traducciones[txtAgregar.Tag.ToString()].Texto;
            btnLimpiar.Text = traducciones[btnLimpiar.Tag.ToString()].Texto;
            grpPago.Text = traducciones[grpPago.Tag.ToString()].Texto;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            ItemDeCompra itemDeCompra = new ItemDeCompra();
            itemDeCompra.cantidad = int.Parse(cantidadText.Text);
            itemDeCompra.precioUnitario = double.Parse(precioUnitarioText.Text);
            itemDeCompra.Marca =  MarcaTxt.Text;
            itemDeCompra.Modelo = modeloTxt.Text;
            itemDeCompra.TipoCambio = (TipoCambio)cmbTipoCambio.SelectedItem;
            itemDeCompra.TipoPago = (TipoPago)cmbTipoPago.SelectedItem;
            itemDeCompra.tipoVehiculo = (TipoVehiculo)cmbTipo.SelectedItem;
            Total = (itemDeCompra.cantidad * itemDeCompra.precioUnitario) + Total;            
            solicitudDeCompra.itemDeCompras.Add(itemDeCompra);
            Actualizar();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            solicitudDeCompra.Total = Total;
            solicitudDeCompraService.Crear(solicitudDeCompra);
            Actualizar();
            MessageBox.Show(traducciones["textCreacion"].Texto, "OK");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
