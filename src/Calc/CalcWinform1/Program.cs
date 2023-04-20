using Calc.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalcWinform1
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
            ApplicationConfiguration.Initialize();

            //DI
            var serviceCollection = new ServiceCollection();

            //serviceCollection.AddScoped<ICalc, CalcCore.CalcNormal>()
            serviceCollection
                             .AddScoped<ICalc, CalcSuperpower.CalcSuperpower>()
                             //.AddScoped<ICalc, CalcCore.CalcNormal>()                             
                             .AddScoped<Form1>();

            using (var serviceProvider = serviceCollection.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();

                Application.Run(form1);
            }

        }
    }
}