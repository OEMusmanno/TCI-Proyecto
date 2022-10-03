using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
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

namespace Campo_TPFinal_UI.Forms.Idioma
{
    public partial class CambioIdioma : Form, IIdiomaService
    {

        private readonly ITraductorService traductorService;
        private readonly IBitacoraService bitacoraService;

        public CambioIdioma(ITraductorService traductorService, IBitacoraService bitacoraService)
        {
            InitializeComponent();
            this.traductorService = traductorService;
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir();
            this.bitacoraService = bitacoraService;
            Session.SuscribirObservador(this);
            actualizar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var lenguaje = (Lenguaje)cmbLenguaje.SelectedItem;
            bitacoraService.GuardarBitacora("se cambio el lenguaje a : " + lenguaje.Nombre, "Bajo");
            Session.traducciones = traductorService.ObtenerTraducciones(lenguaje);
            Session.CambiarIdioma(lenguaje);
            this.Close();
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(Lenguaje idioma = null)
        {
            var traducciones = traductorService.ObtenerTraducciones(idioma);
            btnEditar.Text = traducciones[btnEditar.Tag.ToString()].Texto;
            LenguajeLabel.Text = traducciones[LenguajeLabel.Tag.ToString()].Texto;

        }

        void actualizar() {
            cmbLenguaje.DataSource = traductorService.ObtenerIdiomas();
        }

        private void CambioIdioma_Load(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
