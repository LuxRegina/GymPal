using GymPal.Resources.SavedData;
using System.Diagnostics;
using System.Xml.Linq;

namespace GymPal.Pages;

public partial class FreeweightView2 : ContentPage
{
    private DateTime startTimer;
	private DateTime stopTimer;

	private string notes; // field
	private int reps;
	private int sets;
	private int weight;
	public string Notes
	{
		set { notes = value; }
	}
	public int Reps
	{
		set { reps = value; }
	}
	public int Sets
	{
		set { sets = value; }
	}
	public int Weight
	{
		set { weight = value; }
	}
	//public List<FreeWeightInputData> InputData { get; set; }
	public List<FreeWeightInputData> InputData = new List<FreeWeightInputData>();
	 


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

		if (notes.Length > 0) 
		{
			notes = "Notes";
		}
		if (reps == null)
		{
			reps = 0;
		}
		if (sets == null)
		{
			sets = 0;
		}
		if (weight == null)
		{
			weight = 0;
		}
		/*var newExercise = new FreeWeightInputData
		new FreeWeightInputData(string exerciseName, string notes, int reps, int sets, int weight)
		{
			ExerciseName = exerciseName,
			Notes = notes,
			Reps = reps,
			Sets = sets,
			Weight = weight
		};
		*/
        InputData.Add(new FreeWeightInputData(exerciseName,	notes, reps, sets, weight));

		
		foreach(var data in InputData)
		{
			Debug.WriteLine(data);
		}
			
		
    }
		
}