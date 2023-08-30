using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace CryptoFile
{
    internal class Hardware
    {

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static public extern bool GetVolumeInformation(
        string rootPathName,
        StringBuilder volumeNameBuffer,
        int volumeNameSize,
        out uint volumeSerialNumber,
        out uint maximumComponentLength,
        out uint fileSystemFlags,
        StringBuilder fileSystemNameBuffer,
        int nFileSystemNameSize);

        public static string GetHDDSerial(string disk)
        {
            string rootPath = Path.GetPathRoot(disk);
            StringBuilder volumeName = new StringBuilder(256);
            StringBuilder fileSystemName = new StringBuilder(256);
            uint serialNumber, maxLength, flags;
            if (GetVolumeInformation(rootPath, volumeName, volumeName.Capacity, out serialNumber, out maxLength, out flags, fileSystemName, fileSystemName.Capacity))
            {
                return serialNumber.ToString("X");
            }

            return "Null";
        }

        public static string GetDiskFullName(string path)
        {
            //string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string rootPath = Path.GetPathRoot(path);
            StringBuilder volumeName = new StringBuilder(256);
            StringBuilder fileSystemName = new StringBuilder(256);
            uint serialNumber, maxLength, flags;
            if (GetVolumeInformation(rootPath, volumeName, volumeName.Capacity, out serialNumber, out maxLength, out flags, fileSystemName, fileSystemName.Capacity))
            {
                return $"{volumeName} \"{rootPath[0]}\"";
            }

            return "Null";
        }

        public static string GetKey(string disk)
        {
            string hddSerial = GetHDDSerial(disk);
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(hddSerial);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().Substring(0, 16);
        }
    }
}
