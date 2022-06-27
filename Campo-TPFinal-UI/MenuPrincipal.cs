﻿using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;

namespace Campo_TPFinal_UI
{
    public partial class MenuPrincipal : Form, IIdiomaService
    {
        private readonly RegistrarAlquiler registrarAlquiler;
        private readonly AplicarPenalidad aplicarPenalidad;
        private readonly AdministracionDeUsuarios administrarUsuarios;
        private readonly AdministracionPerfiles administracionPerfiles;
        private readonly IBitacoraService bitacoraService;
        private readonly ITraductorService traductorService;

        public MenuPrincipal(
            IBitacoraService bitacoraService,
            RegistrarAlquiler registrarAlquiler,
            AplicarPenalidad aplicarPenalidad,
            ITraductorService traductorService,
            AdministracionDeUsuarios administrarUsuarios,
            AdministracionPerfiles administracionPerfiles)
        {
            this.bitacoraService = bitacoraService;
            this.registrarAlquiler = registrarAlquiler;
            this.aplicarPenalidad = aplicarPenalidad;
            this.traductorService = traductorService;
            this.administrarUsuarios = administrarUsuarios;
            this.administracionPerfiles = administracionPerfiles;
            InitializeComponent();

            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = registrarAlquiler;
            bitacoraService.GuardarBitacoraDefault("Ingreso a registrar alquiler");
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bitacoraService.GuardarBitacoraDefault("Log out");
            Session.CloseSession();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = aplicarPenalidad;
            bitacoraService.GuardarBitacoraDefault("Ingreso a Penalidades");
            form1.ShowDialog();
        }

        public void ActualizarLenguaje(Lenguaje idioma)
        {
            Traducir(idioma);
        }
        private void Traducir(Lenguaje idioma = null)
        {
            var traducciones = traductorService.ObtenerTraducciones(idioma);

            btnAlquilar.Text = traducciones[btnAlquilar.Tag.ToString()].Texto;
            btnPerfil.Text = traducciones[btnPerfil.Tag.ToString()].Texto;
            btnSalir.Text = traducciones[btnSalir.Tag.ToString()].Texto;
            btnUsuarios.Text = traducciones[btnUsuarios.Tag.ToString()].Texto;

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Session.IsLogged())
                Traducir(Session.GetInstance().usuario.idioma);
            else
                Traducir(); //trae el idioma por default
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var form1 = administrarUsuarios;
            bitacoraService.GuardarBitacoraDefault("Ingreso a administracion de Usuarios");
            form1.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            var form1 = administracionPerfiles;
            bitacoraService.GuardarBitacoraDefault("Ingreso a administracion de Usuarios");
            form1.ShowDialog();
        }
    }
}
