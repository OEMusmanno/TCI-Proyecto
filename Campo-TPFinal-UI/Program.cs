using Campo_TPFinal_BLL;
using Campo_TPFinal_BLL.Alquiler;
using Campo_TPFinal_BLL.Penalidades;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLL.Sistema;
using Campo_TPFinal_BLL.Sistema.Idioma;
using Campo_TPFinal_BLL.Sistema.Perfil;
using Campo_TPFinal_BLL.Vehiculo;
using Campo_TPFinal_BLL.Vehiculo.Estados;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Alquiler;
using Campo_TPFinal_BLLContracts.Penalidad;
using Campo_TPFinal_BLLContracts.Sistema;
using Campo_TPFinal_BLLContracts.Sistema.Idioma;
using Campo_TPFinal_BLLContracts.Sistema.Perfil;
using Campo_TPFinal_BLLContracts.Vehiculo;
using Campo_TPFinal_BLLContracts.Vehiculo.Estados;
using Campo_TPFinal_DAL;
using Campo_TPFinal_DAL.Alquiler;
using Campo_TPFinal_DAL.Sistema.DB;
using Campo_TPFinal_DAL.Sistema.Idioma;
using Campo_TPFinal_DAL.Sistema.Perfiles;
using Campo_TPFinal_DAL.Vehiculo;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Alquiler;
using Campo_TPFinal_DALContracts.Sistema.DB;
using Campo_TPFinal_DALContracts.Sistema.Idioma;
using Campo_TPFinal_DALContracts.Sistema.Perfiles;
using Campo_TPFinal_DALContracts.Vehiculo;
using Campo_TPFinal_UI.Forms.Estacionamiento;
using Campo_TPFinal_UI.Forms.Idioma;
using Campo_TPFinal_UI.Forms.Negocio;
using Campo_TPFinal_UI.Forms.Sistema;
using FluentAssertions.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Campo_TPFinal_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var services = new ServiceCollection();

                ConfigureServices(services);

                using (ServiceProvider serviceProvider = services.BuildServiceProvider())
                {
                    var form1 = serviceProvider.GetRequiredService<Login>();
                    Application.Run(form1);
                }

            }
            catch (Exception)
            {
                throw;
            }
           
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services
              .AddSingleton<IDataAccess, DataAccess>()
              .AddSingleton<IAutoService, AutoService>()
              .AddSingleton<IEstacionamientoService, EstacionamientoService>()
              .AddSingleton<ITipoVehiculoService, TipoVehiculoService>()
              .AddSingleton<IUsuarioService, UsuarioService>()
              .AddSingleton<IUsuarioRepository, UsuarioRepository>()
              .AddSingleton<IAutoRepository, AutoRepository>()
              .AddSingleton<IEstacionamientoRepository, EstacionamientoRepository>()
              .AddSingleton<ITipoVehiculoRepository, TipoVehiculoRepository>()
              .AddSingleton<IBitacoraService, BitacoraService>()
              .AddSingleton<IBitacoraRepository, BitacoraRepository>()
              .AddSingleton<IAlquilerService, AlquilerService>()
              .AddSingleton<IAlquilerRepository, AlquilerRepository>() 
              .AddSingleton<IPenalidadRepository, PenalidadRepository>()
              .AddSingleton<IPerfilRepository, PerfilRepository>()
              .AddSingleton<ITraductorRepository, TraductorRepository>()
              .AddSingleton<IPenalidadService, PenalidadService>()              
              .AddSingleton<IPerfilService, PerfilService>()              
              .AddSingleton<IEstadoService, DisponibleService>()              
              .AddSingleton<IEstadoService, ReservadoService>()
              .AddSingleton<ILoginService, LoginService>()              
              .AddSingleton<ITraductorService, TraductorService>()              
              .AddSingleton<IBackupRepository, BackupRepository>()              
              .AddSingleton<IBackupService, BackupService>()              
              .AddSingleton<IDigitoVerificadorService, DigitoVerificadorService>()              
              .AddSingleton<IDigitoVerificadorRepository, DigitoVerificadorRepository>()              
              .AddSingleton<IControlCambioRepository, ControlCambioRepository>()              
              .AddSingleton<IControlCambioService, ControlCambioService>()              
              .AddSingleton<Login>()
              .AddSingleton<MenuPrincipal>()
              .AddSingleton<LogManager>()
              .AddSingleton<AplicarPenalidad>()
              .AddSingleton<RegistrarAlquiler>()
              .AddSingleton<CambioIdioma>()
              .AddSingleton<GestionIdioma>()
              .AddSingleton<AdministracionDeUsuarios>()
              .AddSingleton<AdministracionPerfiles>()
              .AddSingleton<ControlCambios>()
              .AddSingleton<ABMEstacionamiento>()
              .AddSingleton<ABMAuto>()
              .AddSingleton<Bitacora>()
              .BuildServiceProvider();

        }
    }
}