using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Sistema.Perfil;
using Campo_TPFinal_BLL.Seguridad;
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

namespace Campo_TPFinal_UI
{
    public partial class AdministracionPerfiles : Form, IIdiomaService
    {
        private readonly ITraductorService traductorService;
        private readonly IPerfilService perfilService;


        public AdministracionPerfiles(ITraductorService traductorService, IPerfilService perfilService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            this.perfilService = perfilService;
           
        }

        private void AdministracionPerfiles_Load(object sender, EventArgs e)
        {
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default

            limpiar();
        }
        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }
        private void Traducir(Lenguaje idioma = null)
        {
            var traducciones = traductorService.ObtenerTraducciones(idioma);

            labelNombre.Text = traducciones[labelNombre.Tag.ToString()].Texto;
            btnCrear.Text = traducciones[btnCrear.Tag.ToString()].Texto;
            btnEditar.Text = traducciones[btnEditar.Tag.ToString()].Texto;
            btnBorrar.Text = traducciones[btnBorrar.Tag.ToString()].Texto;
            lblTipo.Text = traducciones[lblTipo.Tag.ToString()].Texto;
            lblRoles.Text = traducciones[lblRoles.Tag.ToString()].Texto;
            lblFamilia.Text = traducciones[lblFamilia.Tag.ToString()].Texto;

        }
        private void limpiar()
        {
            textBox1.Text = "";

            lstFamilia.DataSource = perfilService.GetFamilias();
            lstPatente.DataSource = perfilService.getRoles();
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Familia");
            cmbTipo.Items.Add("Patente");
            cmbTipo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                var rolList = new List<Rol>();
                foreach (var child in lstPatente.SelectedItems)
                {
                    var rol = (Rol)child;
                    rolList.Add(rol);
                }
                var newRol = new Familia() { name = textBox1.Text, patentes = rolList };
                perfilService.addRol(newRol);
            }
            else
            {
                var newRol = new Patente() { name = textBox1.Text };
                perfilService.addRol(newRol);
            }
            limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            perfilService.borrarPerfil((Rol)lstPatente.SelectedItem);
            limpiar();
        }
    }
}
