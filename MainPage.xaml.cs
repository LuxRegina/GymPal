﻿using GymPal.Pages;
using GymPal.Resources.ProfileSaveData;
using Microsoft.Maui.Controls.Internals;
//using static CoreFoundation.DispatchSource;
using System.Text.Json;

namespace GymPal
{
    public partial class MainPage : ContentPage
    {
        public const string fileName = "ProfileData.json";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void RunningButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new RunningView());
		}	

        private async void LogsBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LogsView()); 
        }

        // Makes sure the profile data is updated.
        // Pushes user to ProfileView.
        private async void ProfileBtn_Clicked(object sender, EventArgs e)
        {
            var profileView = new ProfileView();
            if (fileName == null)
                {
				//skapa filen profiledata.json
				using (StreamWriter writer = new StreamWriter(fileName))
				{
					writer.Write("{}");
				}
			}
			var profileData = ProfileView.LoadFromJsonFile(fileName);

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
    }
}