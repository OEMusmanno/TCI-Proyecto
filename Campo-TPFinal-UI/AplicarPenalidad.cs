using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Penalidad;

namespace Campo_TPFinal_UI
{
    public partial class AplicarPenalidad : Form
    {
        private readonly IPenalidadService penalidadService;
        private readonly IUsuarioService usuarioService;


        public AplicarPenalidad(IPenalidadService penalidadService, IUsuarioService usuarioService)
        {
            InitializeComponent();
            this.penalidadService = penalidadService;
            this.usuarioService = usuarioService;
        }

        private void AplicarPenalidad_Load(object sender, EventArgs e)
        {
            grdListadoUsuarios.Columns.Clear();
            grdListadoUsuarios.Columns.Add("id", "id");
            grdListadoUsuarios.Columns["Id"].Visible = false;
            grdListadoUsuarios.Columns.Add("Usuario", "Usuario");
            grdListadoUsuarios.RowHeadersVisible = false;
            grdListadoUsuarios.AllowUserToAddRows = false;
            grdListadoUsuarios.AllowUserToDeleteRows = false;
            grdListadoUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdListadoUsuarios.MultiSelect = false;
            grdListadoUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Actualizar();
        }
        private void Actualizar()
        {
            grdListadoUsuarios.Rows.Clear();
            cmbPenalidad.Items.Clear();

            foreach (Usuario usuario in usuarioService.Listar())
            {
                grdListadoUsuarios.Rows.Add(
                    usuario.Id
                    , usuario.alias
                    );

            }
            foreach (var item in penalidadService.Listar())
            {
                cmbPenalidad.Items.Add(item.descripcion);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string penalidad = cmbPenalidad.SelectedItem.ToString();
            int IdUsuario = int.Parse(grdListadoUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            penalidadService.AplicarPenalidad(penalidad, IdUsuario);
            MessageBox.Show("Se registro correctamente la penalidad", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
