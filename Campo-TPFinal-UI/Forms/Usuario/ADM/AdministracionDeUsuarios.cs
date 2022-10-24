using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Sistema.Perfil;
using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.Sistema.Perfil;
using Microsoft.VisualBasic;
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
    public partial class AdministracionDeUsuarios : Form, IIdiomaService
    {
        private readonly ITraductorService traductorService;
        private readonly IUsuarioService usuarioService;
        private readonly IPerfilService perfilService;
        private readonly IControlCambioService controlCambioService;
        public AdministracionDeUsuarios(ITraductorService traductorService, IUsuarioService usuarioService, IPerfilService perfilService, IControlCambioService controlCambioService)
        {
            this.traductorService = traductorService;
            this.usuarioService = usuarioService;
            InitializeComponent();
            this.perfilService = perfilService;
            this.controlCambioService = controlCambioService;
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(Lenguaje idioma = null)
        {
            var traducciones = traductorService.ObtenerTraducciones(idioma);

            btnCrear.Text = traducciones[btnCrear.Tag.ToString()].Texto;
            btnEditar.Text = traducciones[btnEditar.Tag.ToString()].Texto;
            btnBorrar.Text = traducciones[btnBorrar.Tag.ToString()].Texto;
            lblUsuarios.Text = traducciones[lblUsuarios.Tag.ToString()].Texto;
            lblBloqueados.Text = traducciones[lblBloqueados.Tag.ToString()].Texto;
            lblNombre.Text = traducciones[lblNombre.Tag.ToString()].Texto;
            lblContraseña.Text = traducciones[lblContraseña.Tag.ToString()].Texto;
            btnLimpiar.Text = traducciones[btnLimpiar.Tag.ToString()].Texto;
            btnBloquear.Text = traducciones[btnBloquear.Tag.ToString()].Texto;
            btnDesbloquear.Text = traducciones[btnDesbloquear.Tag.ToString()].Texto;

        }
        private void AdministracionDeUsuarios_Load(object sender, EventArgs e)
        {
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default

            limpiar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario() { alias = txtUsuario.Text, password = CryptographyHelper.encrypt(txtContraseña.Text), rol = (Rol)comboBox1.SelectedItem };
            usuarioService.AgregarUsuario(user);
            limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var user = usuarioService.ObtenerPorAlias(listBox1.SelectedItem.ToString());
                usuarioService.BorrarUsuario(user.Id);
                limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void limpiar()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            label2.Text = "-";
            foreach (var item in usuarioService.Listar())
            {
                listBox1.Items.Add(item.alias);
            }

            foreach (var item in usuarioService.ListarBloqueados())
            {
                listBox2.Items.Add(item.alias);
            }
            comboBox1.DataSource = perfilService.GetFamilias();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var user = usuarioService.ObtenerPorAlias(listBox1.SelectedItem.ToString());
                txtUsuario.Text = user.alias;
                txtContraseña.Text = CryptographyHelper.decrypt(user.password);
                label2.Text = user.Id.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var user = usuarioService.ObtenerPorAlias(listBox1.SelectedItem.ToString());       
                string descripcion = Interaction.InputBox("Agregue una descripcion","Control de cambios", " - ");
                if (user.alias != txtUsuario.Text)
                {
                    user.alias = txtUsuario.Text;
                    controlCambioService.AgregarVersionado(user.Id, user.alias, "usuario", descripcion);
                }
                if (user.password != CryptographyHelper.encrypt(txtContraseña.Text))
                {
                    user.password = CryptographyHelper.encrypt(txtContraseña.Text);
                    controlCambioService.AgregarVersionado(user.Id, user.password, "contraseña", descripcion);
                }
                if (user.rol != (Rol)comboBox1.SelectedItem)
                {
                    user.rol = (Rol)comboBox1.SelectedItem;
                    controlCambioService.AgregarVersionado(user.Id, user.rol.id.ToString(), "rol", descripcion);
                }
                usuarioService.ActualizarUsuario(user);
                limpiar();
            }
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var user = usuarioService.ObtenerPorAlias(listBox1.SelectedItem.ToString());
                usuarioService.bloquear(user.Id);
                limpiar();
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                var user = usuarioService.ObtenerPorAlias(listBox2.SelectedItem.ToString());
                usuarioService.desbloquear(user.Id);
                limpiar();
            }
        }
    }
}
