using Microsoft.Extensions.DependencyInjection;
namespace Calculadora2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Dependency injection
            var services = new ServiceCollection();
            ConfigureServices(services);

            ApplicationConfiguration.Initialize();

            // Build the service provider
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // Resolve and run your main form
                Application.Run(serviceProvider.GetRequiredService<Form1>());
                // Application.Run(new Form1());
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDataTableWrapper,DataTableWrapper>(); 
            // Register your forms
            services.AddTransient<Form1>(); 
        }
    }
}