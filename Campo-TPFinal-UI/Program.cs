using Campo_TPFinal_BLL;
using Campo_TPFinal_BLL.Alquiler;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLL.Vehiculo;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BLLContracts.Alquiler;
using Campo_TPFinal_DAL;
using Campo_TPFinal_DAL.Alquiler;
using Campo_TPFinal_DAL.Vehiculo;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Alquiler;
using Campo_TPFinal_DALContracts.Vehiculo;
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

        private static void ConfigureServices(ServiceCollection services)
        {
            services
              .AddSingleton<IDataAccess, DataAccess>()
              .AddSingleton<IAutoService, AutoService>()
              .AddSingleton<IEstacionamientoService, EstacionamientoService>()
              .AddSingleton<ITipoVehiculoService, TipoVehiculoService>()
              .AddSingleton<IUsuarioRepository, UsuarioRepository>()
              .AddSingleton<IAutoRepository, AutoRepository>()
              .AddSingleton<IEstacionamientoRepository, EstacionamientoRepository>()
              .AddSingleton<ITipoVehiculoRepository, TipoVehiculoRepository>()
              .AddSingleton<IBitacoraService, BitacoraService>()
              .AddSingleton<IBitacoraRepository, BitacoraRepository>()
              .AddSingleton<IAlquilerService, AlquilerService>()
              .AddSingleton<IAlquilerRepository, AlquilerRepository>()
              .AddSingleton<LogManager>()
              .AddSingleton<RegistrarAlquiler>()
              .AddSingleton<MenuPrincipal>()
              .AddSingleton<Login>()
              .BuildServiceProvider();

        }
    }
}