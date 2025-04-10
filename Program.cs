using IdCard.Hanel.Models;
using IdCard.Hanel_obj.auxi;
using Microsoft.Extensions.Configuration;

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
            try
            {
                using var mutex = new Mutex(true, "HANEL_IDCARD_VERIFY", out var createdNew);
                if (!createdNew)
                {
                    throw new Exception("Load device failed");
                }

                // Initialize the singleton instance of AuthenCardDbContext
                var dbContext = AuthenCardDbContext.Instance;

                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();

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