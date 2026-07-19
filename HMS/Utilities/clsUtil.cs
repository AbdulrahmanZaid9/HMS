using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace Utilities
{
    public static class clsUtil
    {
        // Creates the given folder if it doesn't already exist, returning true if it exists or was created successfully.
        public static bool CreateFolderIfDoesNotExist(string destinationFolder)
        {

            if (!Directory.Exists(destinationFolder))
            {
                try
                {
                    Directory.CreateDirectory(destinationFolder);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating directory: " + ex.Message);
                    return false;
                }
            }
            return true;

        }

        // Generates and returns a new unique GUID as a string.
        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }

        // Generates a new GUID-based file name while preserving the original file's extension.
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }

        // Copies an image file to the destination folder under a new GUID-based name and updates the path via ref parameter.
        public static bool CopyImageToProjectImagesFolder(string destinationFolder, ref string imagePath)
        {
            if (!Directory.Exists(destinationFolder))
                return false;

            string destinationFile = Path.Combine(destinationFolder, ReplaceFileNameWithGUID(imagePath));

            try
            {
                File.Copy(imagePath, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine("Error copying file: " + iox.Message);
                return false;
            }

            imagePath = destinationFile;
            return true;
        }

        // Formats a DateTime value as a "dd MMM yyyy" string.
        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd MMM yyyy");
        }

        // Generates a unique transaction reference string using a GUID.
        public static string GenerateTransactionReference()
        {
            return GenerateGUID();
        }
    }
}