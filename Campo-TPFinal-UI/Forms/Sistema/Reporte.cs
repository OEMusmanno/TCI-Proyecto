using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.Sistema.Reportes;
using Campo_TPFinal_BLLContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Campo_TPFinal_BLL.Seguridad;

namespace Campo_TPFinal_UI.Forms.Sistema
{
    public partial class Reporte : Form, IIdiomaService
    {
        private readonly ITraductorService traductorService;
        private readonly IBitacoraService bitacoraService;
        private readonly IReporteService reporteService;
        IDictionary<string, Traduccion> traducciones;

    
        public Reporte(IBitacoraService bitacoraService, ITraductorService traductorService, IReporteService reporteService)
        {
            InitializeComponent();
            this.bitacoraService = bitacoraService;
            this.traductorService = traductorService;
            this.reporteService = reporteService;
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(Lenguaje idioma = null)
        {
            var traducciones = traductorService.ObtenerTraducciones(idioma);
            btnGenerar.Text = traducciones[btnGenerar.Tag.ToString()].Texto;
            lblStartDate.Text = traducciones[lblStartDate.Tag.ToString()].Texto;
            lblEndDate.Text = traducciones[lblEndDate.Tag.ToString()].Texto;

        }


        private void Reporte_Load(object sender, EventArgs e)
        {
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            folder.ShowDialog();            
            reporteService.SacarReporteDeGanancias(folder.SelectedPath, dateTimePicker1.Value, dateTimePicker2.Value);
            MessageBox.Show(Session.traducciones["messageFinalizoCorrectamente"].Texto, "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
