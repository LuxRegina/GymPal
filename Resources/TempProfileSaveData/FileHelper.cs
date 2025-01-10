using Microsoft.Maui.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymPal.Resources.TempProfileSaveData
{
    public class FileHelper
    {
        public static string GetFilePath(string fileName)
        {
            string folderPath = FileSystem.AppDataDirectory;
            return Path.Combine(folderPath, fileName);
        }

        public static void SaveToJsonFile<ProfileModel>(ProfileModel data, string fileName)
        {
            string filePath = GetFilePath(fileName);

            using (var streamWriter = new StreamWriter(filePath, false))
            {
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                streamWriter.Write(json);
            }


            //string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            //File.WriteAllText(filePath, json);
        }
            
    }
}
