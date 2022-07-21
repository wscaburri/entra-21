using Entra21.ExercicioBancoDadosCidades.View;

namespace Entra21.ExercicioBancoDadosCidades
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UnidadeFederativaCadastroEdicaoForm());
        }
    }
}