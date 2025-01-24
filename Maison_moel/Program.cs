using Maison_moel.vue;

namespace Maison_moel
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
            Model.Model.init();
            //Application.Run(new FormConnexion());
            Application.Run(new FormHome(true));
        }
    }
}