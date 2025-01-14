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
        // Creates the json file if it doesn't exist.
        public static string GetFilePath(string fileName)
        {
			string folderPath = FileSystem.AppDataDirectory;
            string newFolderPath = Path.Combine(folderPath, fileName);

            if(fileName == "SaveToLogs.json" && !File.Exists(newFolderPath))
            {                
                File.WriteAllText(newFolderPath, "[]");               

            }
            else if(fileName == "ProfileData.json" && !File.Exists(newFolderPath))
            {
                File.WriteAllText(newFolderPath, "{}");
            }
         
            return newFolderPath;
		}

        // Saves the profile data.
        public static void SaveToJsonFile<ProfileModel>(ProfileModel data, string fileName)
        {
            string filePath = GetFilePath(fileName);
       
            using (var streamWriter = new StreamWriter(filePath, false))
            {
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                streamWriter.Write(json);
            }
        }
         // Save to Logs data.
        public static void SaveWorkoutToJsonFile<ProgramModel>(ProgramModel data, string fileName2)
        {
            string filePath = GetFilePath(fileName2);
        
            using (var streamWriter = new StreamWriter(filePath, false))
            {
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                streamWriter.Write(json);
            }
        }
    }
}
