using GymPal.Resources.SaveToLogs;
using GymPal.Resources.ProfileSaveData;
using Microsoft.Maui.Storage;
using System.Diagnostics;
using Newtonsoft.Json;

namespace GymPal.Pages;

public partial class FreeweightView2 : ContentPage
{
    private DateTime startTimer;
	private DateTime stopTimer;
    private DateTime date;
    private string workoutName;
    public string workoutDuration;
    public string correctDateFormat;
    private string category = "Free Weight";
      
    public FreeweightView2(string workoutname)
	{
		InitializeComponent();
        workoutName = workoutname;
       
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
            correctDateFormat = DateFormatFix(date);
			CompileExerciseData();
			
			OverlayGrid.IsVisible = true;
			await Task.Delay(2500);
			await Navigation.PushAsync(new MainPage());
		}
    }

    // Changes format of date to: day/month - year.
    private string DateFormatFix(DateTime date)
    {
        int year = date.Year;
        int month = date.Month;
        int day = date.Day;

        string dateFixed = $"{day}/{month} - {year}";
        return dateFixed;
    }

    // Counts how long the workout lasted and gives back in format hour:minutes.
    private static string CountTime(DateTime startTimer, DateTime stopTimer)
    {
        TimeSpan duration = stopTimer - startTimer;
        int hour = duration.Hours;
        int minutes = duration.Minutes;
    
        string time = $"{hour} h {minutes} min";		
		return time;		
    }

    //Saves all input from user to a list called ExerciseList.
    private void CompileExerciseData()
    {            
        string exerciseName = BenchPress.Text;
        string notes = BenchPressNotes.Text;

        string textReps = BPReps.Text;
        int reps;
        if (int.TryParse(textReps, out int resultReps))
        {
            reps = resultReps;
        }
        else { reps = 0; }

        string textSets = BPSets.Text;
        int sets;
        if (int.TryParse(textSets, out int resultSets))
        {
            sets = resultSets;
        }
        else { sets = 0; }

        string textWeight = BPWeight.Text;
        int weight;
        if (int.TryParse(textWeight, out int resultWeight))
        {
            weight = resultWeight;
        }
        else { weight = 0; }


        if (notes == "")
        {
            notes = "Notes";
        }
        Debug.WriteLine(category);
        var newProgram = new ProgramModel()
        {
            Name = workoutName,
            Duration = workoutDuration,
            Date = correctDateFormat,            
            Category = category,
            exercise = new List<FreeWeightModel>()
        };
        
        var newExercise = new FreeWeightModel
        {
            ExerciseName = exerciseName,
            Notes = notes,
            Reps = reps,
            Sets = sets,
            Weight = weight
        };
        newProgram.exercise.Add(newExercise);

        // Next exercise (Squat) being added to list below. Do for all exercises!
        if (int.TryParse(SquatReps.Text, out resultReps))
        {
            reps = resultReps;
        }
        else { reps = 0; }

        if (int.TryParse(SquatSets.Text, out resultSets))
        {
            sets = resultSets;
        }
        else { sets = 0; }

        if (int.TryParse(SquatWeight.Text, out resultWeight))
        {
            weight = resultWeight;
        }
        else { weight = 0; }

        newExercise = new FreeWeightModel
        {
            ExerciseName = Squat.Text,
            Notes = SquatNotes.Text,
            Reps = reps,
            Sets = sets,
            Weight = weight
        };
        newProgram.exercise.Add(newExercise);

        // Next exercise (Leg Press) being added to list below. Do for all exercises!
        if (int.TryParse(LegPressReps.Text, out resultReps))
        {
            reps = resultReps;
        }
        else { reps = 0; }

        if (int.TryParse(LegPressSets.Text, out resultSets))
        {
            sets = resultSets;
        }
        else { sets = 0; }

        if (int.TryParse(LegPressWeight.Text, out resultWeight))
        {
            weight = resultWeight;
        }
        else { weight = 0; }

        newExercise = new FreeWeightModel
        {
            ExerciseName = LegPress.Text,
            Notes = LegPressNotes.Text,
            Reps = reps,
            Sets = sets,
            Weight = weight
        };
        newProgram.exercise.Add(newExercise);

        // Next exercise (Dips) being added to list below. Do for all exercises!
        if (int.TryParse(DipsReps.Text, out resultReps))
        {
            reps = resultReps;
        }
        else { reps = 0; }

        if (int.TryParse(DipsSets.Text, out resultSets))
        {
            sets = resultSets;
        }
        else { sets = 0; }

        if (int.TryParse(DipsWeight.Text, out resultWeight))
        {
            weight = resultWeight;
        }
        else { weight = 0; }

        newExercise = new FreeWeightModel
        {
            ExerciseName = Dips.Text,
            Notes = DipsNotes.Text,
            Reps = reps,
            Sets = sets,
            Weight = weight
        };
        newProgram.exercise.Add(newExercise);

        // Next exercise (SitUp) being added to list below. Do for all exercises!
        if (int.TryParse(SitUpReps.Text, out resultReps))
        {
            reps = resultReps;
        }
        else { reps = 0; }

        if (int.TryParse(SitUpSets.Text, out resultSets))
        {
            sets = resultSets;
        }
        else { sets = 0; }

        if (int.TryParse(SitUpWeight.Text, out resultWeight))
        {
            weight = resultWeight;
        }
        else { weight = 0; }

        newExercise = new FreeWeightModel
        {
            ExerciseName = SitUps.Text,
            Notes = SitUpNotes.Text,
            Reps = reps,
            Sets = sets,
            Weight = weight
        };
        newProgram.exercise.Add(newExercise);

        // Next exercise (Deadlift) being added to list below. Do for all exercises!
        if (int.TryParse(DeadliftReps.Text, out resultReps))
        {
            reps = resultReps;
        }
        else { reps = 0; }

        if (int.TryParse(DeadliftSets.Text, out resultSets))
        {
            sets = resultSets;
        }
        else { sets = 0; }

        if (int.TryParse(DeadliftWeight.Text, out resultWeight))
        {
            weight = resultWeight;
        }
        else { weight = 0; }

        newExercise = new FreeWeightModel
        {
            ExerciseName = Deadlift.Text,
            Notes = DeadliftNotes.Text,
            Reps = reps,
            Sets = sets,
            Weight = weight
        };
        newProgram.exercise.Add(newExercise);

        MainPage.ExerciseList.Add(newProgram);
        FilePathHelper.SaveWorkoutToJsonFile(MainPage.ExerciseList, App.fileName2);        
    }  
}