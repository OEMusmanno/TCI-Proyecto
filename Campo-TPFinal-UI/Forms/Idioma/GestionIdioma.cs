using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
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

namespace Campo_TPFinal_UI.Forms.Idioma
{
    public partial class GestionIdioma : Form, IIdiomaService
    {

        private readonly ITraductorService traductorService;
        IDictionary<string, Traduccion> traducciones;
        

        public GestionIdioma(ITraductorService traductorService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void GestionIdioma_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            traducciones = traductorService.ObtenerTraducciones();
            listBox2.DataSource = traductorService.ObtenerIdiomas();
            listBox1.DataSource = traducciones.Keys.ToList();
            txtNombreidioma.Text = "";
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); 
        }
      
        private void Traducir(Lenguaje idioma = null)
        {
            btnBorrar.Text =      Session.traducciones[btnBorrar.Tag.ToString()].Texto;
            btnCrear.Text =       Session.traducciones[btnCrear.Tag.ToString()].Texto;
            btnEditar.Text =      Session.traducciones[btnEditar.Tag.ToString()].Texto;
            LenguajeLabel.Text = Session.traducciones[LenguajeLabel.Tag.ToString()].Texto;
            lblTraducciones.Text = Session.traducciones[lblTraducciones.Tag.ToString()].Texto;
            labelNombre.Text = Session.traducciones[labelNombre.Tag.ToString()].Texto;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            traductorService.CrearNuevoIdioma(txtNombreidioma.Text);
            Actualizar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            traductorService.BorrarIdioma(((Lenguaje)listBox2.SelectedItem).id);
            Actualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            traductorService.EditarTraduccion(textBox1.Text, traducciones.FirstOrDefault(x => x.Key == listBox1.SelectedItem.ToString()).Value.Id);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            traducciones = traductorService.ObtenerTraducciones((Lenguaje)listBox2.SelectedItem);
            textBox1.Text = traducciones[listBox1.SelectedItem.ToString()].Texto;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
