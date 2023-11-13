using AppGASeAGUA.br.com.projeto.VIEW;

namespace AppGASeAGUA
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            int funcionario = 1; string nivel = "Administrador";
            Application.Run(new FrmMenu(funcionario, nivel));
        }
    }
}