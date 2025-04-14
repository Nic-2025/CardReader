using System.Text.Json;

namespace IdCard.Hanel_obj.auxi
{
    public class AppConfig
    {
        //public DatabaseSettings Database { get; set; } = new DatabaseSettings();

        public int CompareMatched { get; set; } = 20;

        public string DataPath { get; set; } = "";


        private static readonly Lazy<AppConfig> _instance = new(LoadConfiguration);

        public static AppConfig Instance => _instance.Value;

        public string GetDatabasePath()
        {
            return Path.Combine(DataPath, "card_reader.db");
        }


        public string GetImagePath()
        {
            return Path.Combine(DataPath, "images");
        }


        public static AppConfig LoadConfiguration()
        {
            AppConfig appConfig = new();
            try
            {
                var configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
                if (!File.Exists(configFilePath))
                {
                    // throw new FileNotFoundException($"Configuration file not found: {configFilePath}");
                    return appConfig; // Return a new instance with default values if the file is not found
                }


                var json = File.ReadAllText(configFilePath);
                appConfig = JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
                if (string.IsNullOrEmpty(appConfig.DataPath))
                {
                    appConfig.DataPath = GetDataPath();
                }

                if (!Directory.Exists(appConfig.DataPath))
                {
                    Directory.CreateDirectory(appConfig.DataPath);
                }

                return appConfig;
            }
            catch (Exception)
            {
                //throw new InvalidOperationException("Failed to load configuration from file.", ex);
                return new AppConfig()
                {
                    DataPath = GetDataPath(),
                    CompareMatched = 60,
                };
            }
        }


        private static string GetDataPath()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var companyName = "Nacencomm";
            var directoryPath = Path.Combine(appDataPath, companyName, "CardReader");

            // Ensure the directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            return directoryPath;
        }
    }
}