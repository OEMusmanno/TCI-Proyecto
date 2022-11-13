using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLL.Vehiculo;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.Vehiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campo_TPFinal_UI.Forms.Negocio
{
    public partial class ABMAuto : Form, IIdiomaService
    {
        private readonly ITraductorService traductorService;
        private readonly IEstacionamientoService estacionamientoService;
        private readonly ITipoVehiculoService tipoVehiculoService;
        private readonly IAutoService autoService;
        IDictionary<string, Traduccion> traducciones;
        List<Campo_TPFinal_BE.Vehiculo.Estacionamiento> Estacionamientos;
        List<TipoVehiculo> tipoVehiculos;

        public ABMAuto(ITraductorService traductorService, IEstacionamientoService estacionamientoService, IAutoService autoService, ITipoVehiculoService tipoVehiculoService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            this.estacionamientoService = estacionamientoService;
            this.autoService = autoService;
            this.tipoVehiculoService = tipoVehiculoService;
        }

        private void ABMAuto_Load(object sender, EventArgs e)
        {
            Estacionamientos = estacionamientoService.Listar();
            tipoVehiculos = tipoVehiculoService.Listar();
            Actualizar();
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir();

            grdAuto.RowHeadersVisible = false;
            grdAuto.AllowUserToAddRows = false;
            grdAuto.AllowUserToDeleteRows = false;
            grdAuto.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdAuto.MultiSelect = false;
            grdAuto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEstacionamiento.RowHeadersVisible = false;
            grdEstacionamiento.AllowUserToAddRows = false;
            grdEstacionamiento.AllowUserToDeleteRows = false;
            grdEstacionamiento.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdEstacionamiento.MultiSelect = false;
            grdEstacionamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Actualizar()
        {
          
            grdAuto.DataSource = autoService.ListarTodo();
            cmbTipo.DataSource = tipoVehiculos;
            grdEstacionamiento.DataSource = estacionamientoService.Listar(); 
            grdEstacionamiento.Columns["id"].Visible = false;
            grdAuto.Columns["id"].Visible = false;
            grdAuto.Columns["Estacionamiento"].Visible = false;
            grdEstacionamiento.Columns["ubicacion"].Width = 200;

        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(Lenguaje idioma = null)
        {
            traducciones = traductorService.ObtenerTraducciones(idioma);
            grdEstacionamiento.Columns["Ubicacion"].HeaderText = traducciones["lblUbicacion"].Texto;
            grdEstacionamiento.Columns["EspaciosTotal"].HeaderText = traducciones["lblEspacio"].Texto;
            grdEstacionamiento.Columns["espaciosLibres"].HeaderText = traducciones["lblEspaciosLibres"].Texto;
            grdAuto.Columns["Marca"].HeaderText = traducciones["lblMarca"].Texto;
            grdAuto.Columns["Modelo"].HeaderText = traducciones["lblModelo"].Texto;
            grdAuto.Columns["TipoVehiculo"].HeaderText= traducciones["lblTipoVehiculo"].Texto;
            grdAuto.Columns["Estado"].HeaderText = traducciones["lblEstado"].Texto;

            lblMarca.Text = traducciones["lblMarca"].Texto;
            lblModelo.Text = traducciones["lblModelo"].Texto;
            lblTipoVehiculo.Text = traducciones["lblTipoVehiculo"].Texto;
            btnCrear.Text = traducciones[btnCrear.Tag.ToString()].Texto;
            txtBloqueado.Text = traducciones[txtBloqueado.Tag.ToString()].Texto;
            btnEditar.Text = traducciones[btnEditar.Tag.ToString()].Texto;
            btnBorrar.Text = traducciones[btnBorrar.Tag.ToString()].Texto;
            btnLimpiar.Text = traducciones[btnLimpiar.Tag.ToString()].Texto;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int id_Estacionamiento = int.Parse(grdEstacionamiento.SelectedRows[0].Cells[1].Value.ToString());
                autoService.Crear(marcaTxt.Text, modeloTxt.Text, id_Estacionamiento, ((TipoVehiculo)cmbTipo.SelectedItem).Id);
                Actualizar();
                MessageBox.Show(traducciones["textCreacion"].Texto, "OK");
            }
            catch (Exception ae)
            {

                throw ae;
            }           
        }

        private void grdAuto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = grdAuto.SelectedRows[0].Cells[0].Value.ToString();
            var auto = autoService.ObtenerPorId(int.Parse(id));
            idText.Text = auto.Id.ToString();
            marcaTxt.Text = auto.Marca;
            modeloTxt.Text = auto.Modelo;
            var index = Estacionamientos.FindIndex(0, Estacionamientos.Count, (x => x.Id == auto.Estacionamiento.Id));
            grdEstacionamiento.Rows[index].Selected = true;
            switch (auto.tipoVehiculo.Id)
            {
                case 1:
                    cmbTipo.SelectedIndex = 0;
                    break;
                case 3:
                    cmbTipo.SelectedIndex = 1;
                    break;
                case 4:
                    cmbTipo.SelectedIndex = 2;
                    break;
                default:
                    cmbTipo.SelectedIndex = 0;
                    break;
            }
            txtBloqueado.Checked = auto.Estado;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_Estacionamiento = int.Parse(grdEstacionamiento.SelectedRows[0].Cells[1].Value.ToString());
                int id_auto = int.Parse(idText.Text);
                autoService.Actualizar(id_auto, marcaTxt.Text, modeloTxt.Text, id_Estacionamiento, ((TipoVehiculo)cmbTipo.SelectedItem).Id, txtBloqueado.Checked);
                Actualizar();
                MessageBox.Show(traducciones["txtUpdate"].Texto, "OK");
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error"); ;
            }           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_Estacionamiento = int.Parse(grdEstacionamiento.SelectedRows[0].Cells[1].Value.ToString());
                int id_auto = int.Parse(idText.Text);
                autoService.Borrar(id_auto, id_Estacionamiento);
                Actualizar();
                MessageBox.Show(traducciones["txtDelete"].Texto, "OK");
            }
            catch (Exception ae)
            {

                throw ae;
            }
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            marcaTxt.Text = "";
            modeloTxt.Text = "";
            idText.Text = "";
        }
    }
}
