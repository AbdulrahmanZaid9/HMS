using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class SecurityHelper
    {
        // Computes the SHA-256 hash of a string and returns it as a Base64-encoded value.
        public static string HashSHA256(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }

        // Saves (or clears, if username is empty) a "remember me" username/password pair to a local file on disk.
        public static bool RememberUsernameAndPassword(string userName, string password)
        {
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string appFolder = Path.Combine(folder, "MyHMS");

                Directory.CreateDirectory(appFolder);

                string filePath = Path.Combine(appFolder, "data.txt");

                if (string.IsNullOrEmpty(userName))
                {
                    if (File.Exists(filePath))
                        File.Delete(filePath);

                    return true;
                }

                string dataToSave = userName + "#//#" + password;

                File.WriteAllText(filePath, dataToSave);

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Reads a previously saved "remember me" username/password pair from the local file, if present.
        public static bool GetStoredCredential(ref string userName, ref string password)
        {
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string appFolder = Path.Combine(folder, "MyHMS");
                string filePath = Path.Combine(appFolder, "data.txt");

                if (!File.Exists(filePath))
                    return false;

                string line = File.ReadAllText(filePath);

                string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                if (result.Length < 2)
                    return false;

                userName = result[0];
                password = result[1];

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}