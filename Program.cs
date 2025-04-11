using IdCard.Hanel.Models;
using System.Reflection;

namespace IdCard.Hanel_obj
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Starting application...");
            // Add custom DLL loading logic
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lib", "dll");
                string assemblyPath = Path.Combine(folderPath, new AssemblyName(args.Name).Name + ".dll");
                return File.Exists(assemblyPath) ? Assembly.LoadFrom(assemblyPath) : null;
            };

            try
            {
                using var mutex = new Mutex(true, "HANEL_IDCARD_VERIFY", out var createdNew);
                if (!createdNew)
                {
                    throw new Exception("Load device failed");
                }

                Console.WriteLine("Creating application database...");
                // Initialize the singleton instance of AuthenCardDbContext
                var dbContext = AuthenCardDbContext.Instance;

                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();

                Console.WriteLine("Creating form....");
                var mainForm = new components.forms.MonitorForm();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Init app error: " + ex.ToString());
            }
        }
    }
}