namespace DemoConcurrencia
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

            //Application.Run(new FrmConcurrencia());
            //Application.Run(new FrmGestionBloqueos());
            //Application.Run(new FrmAtencionAlCliente());
            Application.Run(new FrmPatronSingleton());
        }
    }
    
}