using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Solicitud;
using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLL.Sistema.Idioma;
using Campo_TPFinal_BLL.Sistema.Perfil;
using Campo_TPFinal_BLL.Vehiculo;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.SolicitudDeCompra;
using com.itextpdf.text.pdf;
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
        private readonly SolicitudDeCompra SolicitudDeCompra;
        private List<SolicitudCompra> SolicitudesDeCompra;
        double Total;
        public RevisionDeCompra(ITraductorService traductorService, ISolicitudDeCompraService solicitudDeCompraService, SolicitudDeCompra solicitudDeCompra)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            this.solicitudDeCompraService = solicitudDeCompraService;
            SolicitudDeCompra = solicitudDeCompra;
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

            grdSolicitud.RowHeadersVisible = false;
            grdSolicitud.AllowUserToAddRows = false;
            grdSolicitud.AllowUserToDeleteRows = false;
            grdSolicitud.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdSolicitud.MultiSelect = false;
            grdSolicitud.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Traducir(Lenguaje idioma = null)
        {
            traducciones = traductorService.ObtenerTraducciones(idioma);
            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("contador"))
            {
                txtAprobar.Text = traducciones[txtAprobar.Tag.ToString()].Texto;
                txtRechazar.Text = traducciones[txtRechazar.Tag.ToString()].Texto;
            }
            else
            {
                txtAprobar.Text = traducciones["btnCrear"].Texto;
            }
            txtPendiente.Text = traducciones[txtPendiente.Tag.ToString()].Texto;
        }

        private void Actualizar()
        {
            grdSolicitud.DataSource = (new SolicitudCompra()).itemDeCompras;
            SolicitudesDeCompra = solicitudDeCompraService.Listar();
            lstPendientes.DataSource = SolicitudesDeCompra;

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
            lblEstado.Text = traducciones["lblEstado"].Texto;
            btnExportar.Text = traducciones["btnExportar"].Texto;
            btnImportar.Text = traducciones["btnImportar"].Texto;

            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("contador"))
            {
                txtRechazar.Visible = true;
            }
            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("administrador"))
            {
                txtRechazar.Visible = false;
            }

        }

        private void lstPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPendientes.SelectedItem != null)
            {
                var solicitudCompra = solicitudDeCompraService.ObtenerPorId(((SolicitudCompra)lstPendientes.SelectedItem).Id);
                grdSolicitud.DataSource = solicitudCompra.itemDeCompras;
                txtTotal.Text = solicitudCompra.Total.ToString("C", CultureInfo.CurrentCulture);
                if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("contador"))
                {
                    if (solicitudCompra.estado == Estado.Aprobado || solicitudCompra.estado == Estado.Rechazado)
                    {
                        txtAprobar.Enabled = false;
                        txtRechazar.Enabled = false;
                    }
                    else
                    {
                        txtAprobar.Enabled = true;
                        txtRechazar.Enabled = true;
                    }                    
                }
                if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("administrador"))
                {
                    txtAprobar.Enabled = true;
                }

                txtEstado.Text = solicitudCompra.estado.ToString();
            }
        }

        private void txtAprobar_Click(object sender, EventArgs e)
        {
            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("contador"))
            {
                int id = ((SolicitudCompra)lstPendientes.SelectedItem).Id;
                solicitudDeCompraService.Aprobar(id);
                MessageBox.Show(traducciones["msgAprobacion"].Texto, "OK");
            }
            if (Session.GetInstance().usuario.rol != null && Session.GetInstance().usuario.rol.tienePermiso("administrador"))
            {
                SolicitudDeCompra.ShowDialog();
            }
            Actualizar();
           
        }
        private void txtRechazar_Click(object sender, EventArgs e)
        {
            int id = ((SolicitudCompra)lstPendientes.SelectedItem).Id;
            solicitudDeCompraService.Rechazar(id);
            Actualizar();
            MessageBox.Show(traducciones["msgRechazo"].Texto, "OK");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            folder.ShowDialog();
            SolicitudCompra solicitudCompra = ((SolicitudCompra)lstPendientes.SelectedItem);
            solicitudDeCompraService.ExportarXML(solicitudCompra, folder.SelectedPath);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            var openFolder = new OpenFileDialog
            {
                Filter = "XML (*.xml)|*.xml",
                Title = "Open XML backup"
            };
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                SolicitudesDeCompra.Add(solicitudDeCompraService.ImportarXML(openFolder.FileName));
                lstPendientes.DataSource = null;
                lstPendientes.DataSource = SolicitudesDeCompra;
            }        
            
        }
    }
}
