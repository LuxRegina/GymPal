using GymPal.Resources.SaveToLogs;
using GymPal.Resources.ProfileSaveData;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json;
using System.Collections.ObjectModel;
using GymPal.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace GymPal.Pages;

public partial class LogsView : ContentPage
{
    public List<ProgramModel> workoutData = null;
    public string? workoutName = "";
    public string? workoutDuration = null;
    public string? workoutDate = null;

    public string? workoutName1 = "";
    public string? workoutDuration1 = null;
    public string? workoutDate1 = null;

    public string? workoutCategory = "Free Weight";
    

    public LogsView()
	{        
        InitializeComponent();      
        LoadDataFromJson("SaveToLogs.json");

        NameExercise.Text = workoutName;
        DurationExercise.Text = workoutDuration;      
        DateExercise.Text = workoutDate;
        CategoryExercise.Text = workoutCategory;

        NameExercise1.Text = workoutName1;
        DurationExercise1.Text = workoutDuration1;
        DateExercise1.Text = workoutDate1;
        CategoryExercise1.Text = workoutCategory;
    }

 
    private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

    public void LoadDataFromJson(string fileName2)
    {
        var workoutData = MainPage.LoadProgramFromJsonFile(fileName2);

        if (workoutData.Count == 0)
        {
            
        }
        else if(workoutData.Count == 1)
        {
            Frame0.IsVisible = true;
            workoutName = workoutData[0].Name;
            workoutDuration = workoutData[0].Duration;
            workoutDate = workoutData[0].Date;
        }
        else if(workoutData.Count == 2)
        {
            Frame0.IsVisible = true;
            Frame1.IsVisible = true;

            workoutName = workoutData[0].Name;
            workoutDuration = workoutData[0].Duration;
            workoutDate = workoutData[0].Date;

            workoutName1 = workoutData[1].Name;
            workoutDuration1 = workoutData[1].Duration;
            workoutDate1 = workoutData[1].Date;
        }
        else if (workoutData.Count > 2)
        {
            DisplayAlert("Something went wrong", "Too many programs!", "Close");
        }
                
    }
}