using GymPal.Pages;
using GymPal.Resources.ProfileSaveData;
using GymPal.Resources.SaveToLogs;
using Microsoft.Maui.Controls.Internals;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Diagnostics;

//using static CoreFoundation.DispatchSource;
using System.Text.Json;

namespace GymPal
{
    public partial class MainPage : ContentPage
    {
        public static List<ProgramModel> ExerciseList = new List<ProgramModel>();
    
        public MainPage()
        {
            InitializeComponent();
            ExerciseList = LoadProgramFromJsonFile(App.fileName2);
        }

        private async void RunningButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new RunningView());
		}	

        private async void LogsBtn_Clicked(object sender, EventArgs e)
        {
            var logsView = new LogsView();
            if (App.fileName2 == null)
            {
                //skapar filen SaveToLogs.json
                using (StreamWriter writer = new StreamWriter(App.fileName2))
                {
                    writer.Write("{}");
                }
            }
            var logsData = LoadProgramFromJsonFile(App.fileName2);

            if (logsData != null)
            {
                await Navigation.PushAsync(new LogsView());
            }
            await Navigation.PushAsync(logsView);
                        
        }

        // Makes sure the profile data is updated.
        // Pushes user to ProfileView.
        private async void ProfileBtn_Clicked(object sender, EventArgs e)
        {
            var profileView = new ProfileView();
            if (App.fileName == null)
                {
				//skapa filen profiledata.json
				using (StreamWriter writer = new StreamWriter(App.fileName))
				{
					writer.Write("{}");
				}
			}
			var profileData = ProfileView.LoadFromJsonFile(App.fileName);

            if (profileData != null)
            {               
                profileView.LoadProfile(profileData); 
            }            
            await Navigation.PushAsync(profileView);
        }
        
        private async void FreeweightBtn_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new FreeweightView());
		}

        private async void BodyweightBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BodyWeight());
        }

        private async void CustomBtn_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new Custom());
        }

        public static List<ProgramModel> LoadProgramFromJsonFile(string fileName2)
        {

            string filePath = FilePathHelper.GetFilePath(fileName2);

            string jsonFile = ReadFile(filePath);
            List<ProgramModel>? workouts = JsonConvert.DeserializeObject<List<ProgramModel>>(jsonFile);

            return workouts;
        }

        private static string ReadFile(string path)
        {
            string returnedfile = System.IO.File.ReadAllText(path);
            return returnedfile;
        }
    }
}