
using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Alquiler;

namespace Campo_TPFinal_UI
{
    public partial class RegistrarAlquiler : Form
    {
        private readonly IAutoService autoService;
        private readonly IAlquilerService alquilerService;

        public RegistrarAlquiler(IAutoService autoBLL, IAlquilerService alquilerService)
        {
            this.autoService = autoBLL;
            InitializeComponent();
            this.alquilerService = alquilerService;
        }

        private void Actualizar()
        {
            grdListadoAutos.Rows.Clear();
            foreach (Auto auto in autoService.Listar())
            {
                grdListadoAutos.Rows.Add(
                    auto.Id
                    ,auto.Marca
                    ,auto.Modelo
                    ,auto.Estacionamiento.ubicacion
                    ,auto.tipoVehiculo.Nombre
                    ,auto.tipoVehiculo.MinutoRecorrido
                    ,auto.tipoVehiculo.MinutoDetenido
                    ,auto.tipoVehiculo.PrecioDia
                    ,auto.tipoVehiculo.PrecioHora
                    ,auto.tipoVehiculo.PrecioKmExtra                    
                    );

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
            grdListadoAutos.Columns.Add("Modelo", "Modelo");
            grdListadoAutos.Columns.Add("Ubicacion", "Ubicacion");
            grdListadoAutos.Columns["Ubicacion"].Width = 200;
            grdListadoAutos.Columns.Add("TipoVehiculo", "Tipo Vehiculo");
            grdListadoAutos.Columns.Add("MinutoRecorrido", "Minuto Recorrido");
            grdListadoAutos.Columns["MinutoRecorrido"].DefaultCellStyle.Format = "c";
            grdListadoAutos.Columns.Add("MinutoDetenido", "Minuto Detenido");
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

            Actualizar();
        }
    }
}