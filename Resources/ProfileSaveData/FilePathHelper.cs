﻿using Microsoft.Maui.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymPal.Resources.ProfileSaveData
{
    public class FilePathHelper
    {
        // Gets the correct filepath for the stored data.
        public static string GetFilePath(string fileName)
        {
            string folderPath = FileSystem.AppDataDirectory; // AddDataDirectory isnt visible to user. But it exists or is created on first run.
            return Path.Combine(folderPath, fileName);
        }

        // Saves the profile data.
        public static void SaveToJsonFile<ProfileModel>(ProfileModel data, string fileName)
        {
            string filePath = GetFilePath(fileName);

            string json = JsonConvert.SerializeObject(data); 
            File.WriteAllText(filePath,json);         

        }            
    }
}