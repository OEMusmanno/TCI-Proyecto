using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Solicitud;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLL.Sistema.Idioma;
using Campo_TPFinal_BLL.Sistema.Perfil;
using Campo_TPFinal_BLL.Vehiculo;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.SolicitudDeCompra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campo_TPFinal_UI.Forms.SolicitudDeCompra
{
    public partial class RevisionDeCompra : Form, IIdiomaService
    {
        private readonly ITraductorService traductorService;
        IDictionary<string, Traduccion> traducciones;
        private readonly ISolicitudDeCompraService solicitudDeCompraService;
        double Total;
        public RevisionDeCompra(ITraductorService traductorService, ISolicitudDeCompraService solicitudDeCompraService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            this.solicitudDeCompraService = solicitudDeCompraService;
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void RevisionDeCompra_Load(object sender, EventArgs e)
        {
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir();
            Actualizar();
        }

        private void Traducir(Lenguaje idioma = null)
        {
            traducciones = traductorService.ObtenerTraducciones(idioma);
            txtAprobar.Text = traducciones[txtAprobar.Tag.ToString()].Texto;
            txtRechazar.Text = traducciones[txtRechazar.Tag.ToString()].Texto;
        }

        private void Actualizar()
        {
            grdSolicitud.DataSource = (new SolicitudCompra()).itemDeCompras;
            lstPendientes.DataSource = solicitudDeCompraService.Listar();
            

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


        }

        private void lstPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPendientes.SelectedItem != null)
            {
                var solicitudCompra = solicitudDeCompraService.ObtenerPorId(((SolicitudCompra)lstPendientes.SelectedItem).Id);
                grdSolicitud.DataSource = solicitudCompra.itemDeCompras;
            }
        }
    }
}
