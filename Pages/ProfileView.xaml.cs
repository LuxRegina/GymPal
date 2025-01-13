using GymPal.Resources.ProfileSaveData;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json;


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

    // Saves the profile input data.
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

        FilePathHelper.SaveToJsonFile(data,fileName);
        DisplayAlert("Success!","Profile Saved!", "Close");        
    }

    // Loads previously saved data from profileView.
    public static ProfileModel LoadFromJsonFile(string fileName)
    {
        string filePath = FilePathHelper.GetFilePath(fileName);
        string jsonFile = ReadFile(filePath);
        ProfileModel? profile = JsonConvert.DeserializeObject<ProfileModel>(jsonFile);
        
        return profile;
    }

    // Reads content of ProfileData.
    private static string ReadFile(string path)
    {
        string returnedfile = System.IO.File.ReadAllText(path);
        return returnedfile;
    }

    // Updates the UI with the previously saved profile data.
    public void LoadProfile(ProfileModel profileData)
    {
        if (profileData != null)
        {
            ProfileName.Text = profileData.Name;
            Weight.Text = profileData.Weight.ToString();
            GoalWeight.Text = profileData.GoalWeight.ToString();
            SpecificGoal.Text = profileData.SpecificGoal;
        }      
    }
}