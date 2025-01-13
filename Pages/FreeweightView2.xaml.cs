using GymPal.Resources.SavedData;
using System.Diagnostics;

namespace GymPal.Pages;

public partial class FreeweightView2 : ContentPage
{
    private DateTime startTimer;
	private DateTime stopTimer;

	public List<FreeWeightInputData> InputData { get; set; } 
	

    public FreeweightView2()
	{
		InitializeComponent();
	}

	public async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FreeweightView());
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
						
		}
		else if (StartBtn.Text == "Finish")
		{
			StartBtn.Text = "Start";
			TimerGrid.IsVisible = false;
			TimeDisplay.Text = $"00:00";
			BackIcon.IsEnabled = true;
			
			stopTimer = DateTime.Now;			

			//Send this along with the other data to Logs!
			TimeSpan workoutDuration = CountTime(startTimer, stopTimer);

			// TBD Save to Logs!!

			CompileExerciseData();


			OverlayGrid.IsVisible = true;
			await Task.Delay(3000);
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

    private void CompileExerciseData()
    {
		string exerciseName = ExerciseName.Text;
		string notes = BenchPressNotes.Text;
		int reps = Int32.Parse(RepsNotes1.Text);
		int sets = Int32.Parse(SetsNotes1.Text);
		int weight = Int32.Parse(WeightNotes1.Text);

		var newExercise = new FreeWeightInputData
		{
			ExerciseName = exerciseName,
			Notes = notes,
			Reps = reps,
			Sets = sets,
			Weight = weight
		};
        InputData.Add(newExercise);

		
		foreach(var data in InputData)
		{
			Debug.WriteLine(data);
		}
			
		
    }
		
}