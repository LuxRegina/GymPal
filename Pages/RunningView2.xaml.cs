using System.Diagnostics;

namespace GymPal.Pages;

public partial class RunningView2 : ContentPage
{
	private DateTime startTimer;
	private DateTime stopTimer;

	public RunningView2()
	{
		InitializeComponent();
	}

	public async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new RunningView());
	}


	public RunningView2(string formToShow)
	{
		InitializeComponent();
		switch (formToShow)
		{
			case "Run":
				RunForm.IsVisible = true;
				break;
			case "Walk":
				WalkForm.IsVisible = true;
				break;
			case "Swim":
				SwimForm.IsVisible = true;
				break;
			case "Cycle":
				CycleForm.IsVisible = true;
				break;
			case "Other":
				OtherForm.IsVisible = true;
				break;
		}
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

}