using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.Sistema.Perfil;
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
    public partial class Bitacora : Form, IIdiomaService
    {
        private readonly ITraductorService traductorService;
        private readonly IBitacoraService bitacoraService;
        private readonly IUsuarioService usuarioService;
        private List<BitacoraLog> bitacoras;

        IDictionary<string, Traduccion> traducciones;
        public Bitacora(ITraductorService traductorService, IBitacoraService bitacora, IUsuarioService usuarioService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            this.bitacoraService = bitacora;
            this.usuarioService = usuarioService;
            bitacoras = bitacoraService.Listar();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {          
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir();
            Actualizar();

            Session.SuscribirObservador(this);
            grdBitacora.RowHeadersVisible = false;
            grdBitacora.AllowUserToAddRows = false;
            grdBitacora.AllowUserToDeleteRows = false;
            grdBitacora.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdBitacora.MultiSelect = false;
            grdBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Actualizar()
        {
            cmbUser.DataSource = usuarioService.Listar();
            cmbRisk.DataSource = new List<string>() { "Alto", "Medio", "Bajo" };
            grdBitacora.DataSource = bitacoras;
            grdBitacora.Columns["riesgo"].HeaderText = traducciones["lblRisk"].Texto;
            grdBitacora.Columns["descripcion"].HeaderText = traducciones["lblDescripcion"].Texto;
            grdBitacora.Columns["usuario"].HeaderText = traducciones["userLabel"].Texto;
            grdBitacora.Columns["fecha"].HeaderText = traducciones["lblDate"].Texto;
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(Lenguaje idioma = null)
        {
            traducciones = traductorService.ObtenerTraducciones(idioma);

            lblStartDate.Text = traducciones[lblStartDate.Tag.ToString()].Texto;
            lblRisk.Text = traducciones[lblRisk.Tag.ToString()].Texto;
            lblEndDate.Text = traducciones[lblEndDate.Tag.ToString()].Texto;
            userLabel.Text = traducciones[userLabel.Tag.ToString()].Texto;
            btnLimpiar.Text = traducciones[btnLimpiar.Tag.ToString()].Texto;

        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            grdBitacora.DataSource = bitacoras;
            grdBitacora.DataSource = ((List<BitacoraLog>)grdBitacora.DataSource).Where(x => x.usuario.alias == (cmbUser.SelectedItem?.ToString() ?? "Admin")).ToList();
            grdBitacora.DataSource = ((List<BitacoraLog>)grdBitacora.DataSource).Where(x => x.fecha <= dateTimePicker2.Value).ToList();
            grdBitacora.DataSource = ((List<BitacoraLog>)grdBitacora.DataSource).Where(x => x.fecha >= dateTimePicker1.Value).ToList();
            grdBitacora.DataSource = ((List<BitacoraLog>)grdBitacora.DataSource).Where(x => x.riesgo == (cmbRisk.SelectedItem?.ToString() ?? "Alto")).ToList() ;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            cmbRisk.DataSource = null;
            cmbUser.DataSource = null;
            Actualizar();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            filtrar();
        }
        private void cmbRisk_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            filtrar();
        }
    }
}
