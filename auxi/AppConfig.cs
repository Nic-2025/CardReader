using Microsoft.Extensions.Configuration;

namespace IdCard.Hanel_obj.auxi
{
    //public class DatabaseSettings
    //{
    //    public string Path { get; set; }

    //    public DatabaseSettings()
    //    {
    //        var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    //        var companyName = "MyCompany"; // Replace with your actual company name
    //        var directoryPath = System.IO.Path.Combine(appDataPath, companyName);

    //        // Ensure the directory exists
    //        if (!Directory.Exists(directoryPath))
    //        {
    //            Directory.CreateDirectory(directoryPath);
    //        }

    //        Path = System.IO.Path.Combine(directoryPath, "authcard.db");
    //    }
    //}

    public class AppConfig
    {
        //public DatabaseSettings Database { get; set; } = new DatabaseSettings();

        public int CompareMatched { get; set; } = 60;

        public string DataPath { get; set; } = "";


        private static readonly Lazy<AppConfig> _instance = new(LoadConfiguration);

        public static AppConfig Instance => _instance.Value;

        public string GetDatabasePath()
        {
            return Path.Combine(DataPath, "cardreader.db");
        }


        public string GetImagePath()
        {
            return Path.Combine(DataPath, "images");
        }


        public static AppConfig LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();
            var appConfig = new AppConfig();
            configuration.Bind(appConfig);

            if (appConfig.DataPath == "")
            {
                appConfig.DataPath = GetDataPath();
            }

            return appConfig;
        }


        private static string GetDataPath()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var companyName = "Nacencom"; // Replace with your actual company name
            var directoryPath = Path.Combine(appDataPath, companyName);

            // Ensure the directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            return directoryPath;
        }
    }
}