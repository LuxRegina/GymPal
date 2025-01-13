using Microsoft.Maui.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymPal.Resources.ProfileSaveData
{
    public class FilePathHelper
    {
        // Gets the correct filepath for the stored data.
        public static string GetFilePath(string fileName)
        {
			string folderPath = FileSystem.AppDataDirectory;
            Debug.WriteLine($"sökväg folderpath: {folderPath}");
			Debug.WriteLine($"sökväg filename: {fileName}");
			// Create the folder if it doesn't exist

			return Path.Combine(folderPath, fileName);
		}

        // Saves the profile data.
        public static void SaveToJsonFile<ProfileModel>(ProfileModel data, string fileName)
        {
            string filePath = GetFilePath(fileName);
            Debug.WriteLine($"sökväg: {filePath}");
            using (var streamWriter = new StreamWriter(filePath, false))
            {
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                streamWriter.Write(json);
            }
        }            
    }
}
