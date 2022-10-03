using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLL.Sistema.Idioma;
using Campo_TPFinal_BLL.Sistema.Perfil;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campo_TPFinal_UI.Forms.Sistema
{
    public partial class ControlCambios : Form, IIdiomaService
    {
        private readonly ITraductorService traductorService;
        private readonly IBitacoraService bitacoraService;
        private readonly IControlCambioService controlCambioService;

        public ControlCambios(ITraductorService traductorService, IBitacoraService bitacoraService, IControlCambioService controlCambioService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            this.bitacoraService = bitacoraService;
            this.controlCambioService = controlCambioService;
        }

        private void ControlCambios_Load(object sender, EventArgs e)
        {
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir();
            Actualizar();

            Session.SuscribirObservador(this);
            grdListado.RowHeadersVisible = false;
            grdListado.AllowUserToAddRows = false;
            grdListado.AllowUserToDeleteRows = false;
            grdListado.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdListado.MultiSelect = false;
            grdListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Actualizar()
        {
            grdListado.DataSource = controlCambioService.Listar();
            grdListado.Columns["descripcion"].HeaderText = Session.traducciones["lblDescripcion"].Texto;
            grdListado.Columns["usuario"].HeaderText = Session.traducciones["userLabel"].Texto;
            grdListado.Columns["fecha"].HeaderText = Session.traducciones["lblDate"].Texto;
            txtVersionado.Text = "";
            txtDescripcion.Text = "";
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }
        private void Traducir(Lenguaje idioma = null)
        {

            Session.traducciones = traductorService.ObtenerTraducciones(idioma);
            lblDescripcion.Text = Session.traducciones[lblDescripcion.Tag.ToString()].Texto;
            lblListado.Text = Session.traducciones[lblListado.Tag.ToString()].Texto;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            controlCambioService.AgregarVersionado(txtVersionado.Text, txtDescripcion.Text);
            Actualizar();            
        }

        private void grdListado_SelectionChanged(object sender, EventArgs e)
        {
            if (grdListado.SelectedRows.Count != 0)
            {
                descripcionText.Text = grdListado.SelectedRows[0]?.Cells["descripcion"].Value.ToString() ?? "";

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
