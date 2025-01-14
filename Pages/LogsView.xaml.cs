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
    public DateTime? workoutDate = null;

    public string? workoutName1 = "";
    public string? workoutDuration1 = null;
    public DateTime? workoutDate1 = null;

    public string? workoutCategory = "Free Weight";

    public LogsView()
	{        
        InitializeComponent();
       //$"{DateTime.Now:HH:mm}";
        LoadDataFromJson("SaveToLogs.json");

        NameExercise.Text = workoutName;
        DurationExercise.Text = workoutDuration;
      
        DateExercise.Text = workoutDate.ToString();

        NameExercise1.Text = workoutName1;
        DurationExercise1.Text = workoutDuration1;
        DateExercise1.Text = workoutDate1.ToString();


    }

    public void LoadLogs(List<ProgramModel> logsData)
    {
        if (logsData != null)
        {
            //CollectionView collectionView = new CollectionView();
            //collectionView.SetBinding(ItemsView.ItemsSourceProperty, "ExerciseList");

            //NameExercise.Text = logsData.Name;
            
        }
    }

    private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

    public void LoadDataFromJson(string fileName2)
    {
        var workoutData = MainPage.LoadProgramFromJsonFile(fileName2);

        //Debug.WriteLine(workoutData[0].Name);
        workoutName = workoutData[0].Name;
        workoutDuration = workoutData[0].Duration;
        workoutDate = workoutData[0].Date;

        //Debug.WriteLine(workoutData.Count);

        workoutName1 = workoutData[1].Name;
        workoutDuration1 = workoutData[1].Duration;
        workoutDate1 = workoutData[1].Date;
    
    }
   
}