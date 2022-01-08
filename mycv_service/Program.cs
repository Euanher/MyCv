using System.ServiceProcess;

namespace mycv_service
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            ServiceBase[] ServicesToRun = new ServiceBase[]
{
                new Service1()
};
            ServiceBase.Run(ServicesToRun);
        }
    }
}
