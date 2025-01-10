using GymPal.Resources.TempProfileSaveData;
using System.IO;
//using Microsoft.UI.Xaml;
using System.Diagnostics;
using System.Text.Json;
//using Windows.System;

namespace GymPal.Pages;

public partial class ProfileView : ContentPage
{
    public const string fileName = "ProfileData.json";

    public ProfileView()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

    private void SaveBtn_Clicked(object sender, EventArgs e)
    {
        string name = ProfileName.Text;
        int weight = Int32.Parse(Weight.Text);
        int goalWeight = Int32.Parse(GoalWeight.Text);
        string specificGoal = SpecificGoal.Text;

        var data = new ProfileModel
        {
            Name = name,
            Weight = weight,
            GoalWeight = goalWeight,
            SpecificGoal = specificGoal
        };

        FileHelper.SaveToJsonFile(data,fileName);
        DisplayAlert("Success", "Profile Saved!", "OK");
        
    }

    public static T LoadFromJsonFile<T>(string fileName)
    {
        string filePath = FileHelper.GetFilePath(fileName);

        string jsonFile = ReadFile(filePath);
        //if (File.Exists(filePath) && fileName != null)
        //{
        //    using (var streamReader = new StreamReader(filePath))
        //    {
        //        string json = streamReader.ReadToEnd();
        //        Debug.WriteLine(json);
        //        return JsonSerializer.Deserialize<T>(json);
        //    }
        //}

        return default;
    }

    public void LoadProfile()
    {
        // Display the data from JSON file to the UI.
        var data = LoadFromJsonFile<ProfileModel>(fileName);

        if (data != null)
        {
            ProfileName.Text = data.Name;
            Weight.Text = data.Weight.ToString();
            GoalWeight.Text = data.GoalWeight.ToString();
            SpecificGoal.Text = data.SpecificGoal;
        }
      
    }



}