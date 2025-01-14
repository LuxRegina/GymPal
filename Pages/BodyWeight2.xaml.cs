using GymPal.Resources.SaveToLogs;
using GymPal.Resources.ProfileSaveData;
using Microsoft.Maui.Storage;
using System.Diagnostics;
using Newtonsoft.Json;
using Microsoft.Maui.Graphics;
namespace GymPal.Pages;

public partial class BodyWeight2 : ContentPage
{

    private DateTime startTimer;
    private DateTime stopTimer;
    private string workoutName;
    public TimeSpan workoutDuration;
    private DateTime date;
    private string category = "Body Weight";

    public BodyWeight2(string workoutname)
	{
		InitializeComponent();
        workoutName = workoutname;
	}

	public async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BodyWeight());
	}

    // Changes text in StartBtn
    // Starts/stops the timer
    // Shows start time to user
    // Makes Backbutton unclickable if workout is in progress
    // Moves user to Homepage when workout is done. (pressed Finish)
    private async void StartBtn_Clicked(object sender, EventArgs e)
    {
        if (StartBtn.Text == "Start")
        {
            StartBtn.Text = "Finish";
            TimerGrid.IsVisible = true;
            BackIcon.IsEnabled = false;

            TimeDisplay.Text = $"{DateTime.Now:HH:mm}";
            startTimer = DateTime.Now;
            date = DateTime.Now;

        }
        else if (StartBtn.Text == "Finish")
        {
            StartBtn.Text = "Start";
            TimerGrid.IsVisible = false;
            TimeDisplay.Text = $"00:00";
            BackIcon.IsEnabled = true;

			stopTimer = DateTime.Now;

			workoutDuration = CountTime(startTimer, stopTimer);
            //CompileExerciseData();
            		
			OverlayGrid.IsVisible = true;
			await Task.Delay(2500);
			await Navigation.PushAsync(new MainPage());
		}
    }

    // Counts how long the workout lasted.
    private static TimeSpan CountTime(DateTime startTimer, DateTime stopTimer)
    {
        TimeSpan duration = stopTimer - startTimer;
        Debug.WriteLine($"Duration of workout: {duration}");

        return duration;
    }

    //Saves all input from user to a list called ExerciseList.
    //private void CompileExerciseData()
    //{
    //    string exerciseName = RussianTwist.Text;
    //    string notes = RussianTwistNotes.Text;

    //    string textReps = RussianTwistReps.Text;
    //    int reps;
    //    if (int.TryParse(textReps, out int resultReps))
    //    {
    //        reps = resultReps;
    //    }
    //    else { reps = 0; }

    //    string textSets = RussianTwistSets.Text;
    //    int sets;
    //    if (int.TryParse(textSets, out int resultSets))
    //    {
    //        sets = resultSets;
    //    }
    //    else { sets = 0; }       

    //    if (notes == "")
    //    {
    //        notes = "Notes";
    //    }


    //    var newProgram = new ProgramModel()
    //    {
    //        Name = workoutName,
    //        Duration = workoutDuration,
    //        Date = date,
    //        Category = category,
    //        exercise = new List<BodyWeightModel>()
    //    };

    //    var newExercise = new BodyWeightModel
    //    {
    //        ExerciseName = exerciseName,
    //        Notes = notes,
    //        Reps = reps,
    //        Sets = sets,
    //    };
    //    newProgram.exercise.Add(newExercise);
    //}
}