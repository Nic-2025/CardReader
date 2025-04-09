using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace IdCard.Hanel_obj.auxi
{
    public enum LicenseState
    {
        Valid = 0,
        Invalid = -1,
        InvalidDevice = -2,
        Expired = -10,
    }

    public static class LicenseUtils
    {
        public const string LicensePath = @".\data\data.bin"; // Changed from static to const

        public const string AesKeyHex = "603deb1015ca71be2b73aef0857d77811f352c073b6108d72d9810a30914dff4";
        public const string PublicKeyBase64 = "1lB4WvgA10UDuy98WNnf9A==";

        // public static bool ValidateLicense(string licenseHex, string publicKeyBase64, out DateTime expired)
        // {
        //     expired = DateTime.MinValue; // Initialize expired to a default value

        //     var licenseBytes = Convert.FromHexString(licenseHex);
        //     var data = new byte[16];
        //     var signature = new byte[8];

        //     Array.Copy(licenseBytes, 0, data, 0, 16);
        //     Array.Copy(licenseBytes, 16, signature, 0, 8);

        //     var key = Convert.FromBase64String(publicKeyBase64);
        //     using var hmac = new HMACSHA256(key);
        //     var computedSignature = hmac.ComputeHash(data.ToArray()).Take(8).ToArray();

        //     if (!computedSignature.SequenceEqual(signature))
        //         return false;

        //     uint packedValue = BitConverter.ToUInt32(data, 12); // Convert byte array to uint
        //     int unpackedX = (int)(packedValue >> 24); // Extract the year value
        //     int unpackedY = (int)((packedValue >> 16) & 0xFF); // Extract the month value
        //     int unpackedZ = (int)((packedValue >> 8) & 0xFF); // Extract the day value

        //     expired = new DateTime(unpackedX + 2024, unpackedY, unpackedZ);

        //     return expired >= DateTime.Now;
        // }

        public static LicenseState ValidateLicense(string licenseHex, string publicKeyBase64, ushort companyCode, uint deviceCode, out DateTime expired)
        {
            var licenseBytes = Convert.FromHexString(licenseHex);
            var data = new byte[16];
            var signature = new byte[8];
            expired = DateTime.MinValue; // Initialize expired to a default value

            Array.Copy(licenseBytes, 0, data, 0, 16);
            Array.Copy(licenseBytes, 16, signature, 0, 8);

            var key = Convert.FromBase64String(publicKeyBase64);
            using var hmac = new HMACSHA256(key);
            var computedSignature = hmac.ComputeHash(data.ToArray()).Take(8).ToArray();

            if (!computedSignature.SequenceEqual(signature))
                return LicenseState.Invalid;

            ushort unpackCompanyCode = BitConverter.ToUInt16(data, 1); // Convert byte array to uint
            uint unpackDeviceCode = BitConverter.ToUInt32(data, 3); // Convert byte array to uint

            if (unpackCompanyCode != companyCode || unpackDeviceCode != deviceCode) // Check company code and device code
                return LicenseState.InvalidDevice;

            uint packedValue = BitConverter.ToUInt32(data, 12); // Convert byte array to uint
            int unpackedX = (int)(packedValue >> 24); // Extract the year value
            int unpackedY = (int)((packedValue >> 16) & 0xFF); // Extract the month value
            int unpackedZ = (int)((packedValue >> 8) & 0xFF); // Extract the day value

            expired = new DateTime(unpackedX + 2024, unpackedY, unpackedZ);

            return expired >= DateTime.Now ? LicenseState.Valid : LicenseState.Expired;
        }

        public static void SaveLicenseToFile(string licenseHex, string aesKeyHex)
        {
            var licenseBytes = Convert.FromHexString(licenseHex);
            var aesKey = Convert.FromHexString(aesKeyHex);

            using var aes = Aes.Create();
            aes.Key = aesKey;
            aes.GenerateIV();
            using var encryptor = aes.CreateEncryptor();
            using var fs = new FileStream(LicensePath, FileMode.Create, FileAccess.Write);
            fs.Write(aes.IV, 0, aes.IV.Length);
            using var cryptoStream = new CryptoStream(fs, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(licenseBytes, 0, licenseBytes.Length);
        }

        public static string LoadLicenseFromFile(string aesKeyHex)
        {
            var aesKey = Convert.FromHexString(aesKeyHex);

            using var aes = Aes.Create();
            aes.Key = aesKey;

            using var fs = new FileStream(LicensePath, FileMode.Open, FileAccess.Read);
            var iv = new byte[16];
            fs.Read(iv, 0, iv.Length);
            aes.IV = iv;

            using var decryptor = aes.CreateDecryptor();
            using var cryptoStream = new CryptoStream(fs, decryptor, CryptoStreamMode.Read);
            using var ms = new MemoryStream();
            cryptoStream.CopyTo(ms);

            return Convert.ToHexString(ms.ToArray());
        }
    }

    public class License
    {
        public LicenseState Status { get; } = LicenseState.Invalid;

        public DateTime Expired { get; } = DateTime.MinValue;

        public string LicenseHex { get; }

        public License(ushort companyCode, uint deviceCode)
        {
            try
            {
                // 02420004000000A6EEF727D1EE090402D16051F0CB8FB69F
                if (File.Exists(LicenseUtils.LicensePath))
                {
                    LicenseHex = LicenseUtils.LoadLicenseFromFile(LicenseUtils.AesKeyHex);
                    Status = LicenseUtils.ValidateLicense(LicenseHex, LicenseUtils.PublicKeyBase64, companyCode, deviceCode, out DateTime expired);
                    Expired = expired;
                }
                else
                {
                    LicenseHex = string.Empty;
                    Status = LicenseState.Invalid;
                }
            }
            catch
            {
                LicenseHex = string.Empty;
                Status = LicenseState.Invalid;
            }
        }

        public License(string license, ushort companyCode, uint deviceCode)
        {
            try
            {
                LicenseHex = license;
                // 02420004000000A6EEF727D1EE090402D16051F0CB8FB69F
                Status = LicenseUtils.ValidateLicense(LicenseHex, LicenseUtils.PublicKeyBase64, companyCode, deviceCode, out DateTime expired);
                Expired = expired;
                if (Status == LicenseState.Valid)
                {
                    LicenseUtils.SaveLicenseToFile(license, LicenseUtils.AesKeyHex);
                }
            }
            catch
            {
                LicenseHex = string.Empty;
                Status = LicenseState.Invalid;
            }
        }
    }
}
