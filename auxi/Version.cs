using System.Text;

namespace IdCard.Hanel_obj.auxi
{

    public class Version
    {
        //public string VersionNumber { get; set; }

        public int Major { get; set; }
        public int Minor { get; set; }

        public string GetVersion()
        {
            return $"{Major}.{Minor}";
        }

        public static Version Parse(string versionString)
        {
            var versionParts = versionString.Split('.');
            if (versionParts.Length != 2)
            {
                throw new FormatException("Invalid version format. Expected format: Major.Minor");
            }
            return new Version
            {
                Major = int.Parse(versionParts[0]),
                Minor = int.Parse(versionParts[1])
            };
        }

        private static readonly Version _current = new()
        {
            Major = 1,
            Minor = 0
        };

        public static Version Current => _current;
    }
}