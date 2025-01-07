using System.Diagnostics;

namespace GymPal.Pages;

public partial class FreeweightView2 : ContentPage
{
    private DateTime startTimer;
	private DateTime stopTimer;


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
	// Makes Backbutton unclickable until user presses Finish
    private void StartBtn_Clicked(object sender, EventArgs e)
    {
		if (StartBtn.Text == "Start")
		{
			StartBtn.Text = "Finish";
			TimerGrid.IsVisible = true;
			BackIcon.IsEnabled = false;

			TimeDisplay.Text = $"{DateTime.Now:HH:mm}";
			startTimer = DateTime.Now;

			Debug.WriteLine(startTimer);
		}
		else if (StartBtn.Text == "Finish")
		{
			StartBtn.Text = "Start";
			TimerGrid.IsVisible = false;
			TimeDisplay.Text = $"00:00";
			BackIcon.IsEnabled = true;

			stopTimer = DateTime.Now;			

			TimeSpan workoutDuration = CountTime(startTimer, stopTimer);

			// TBD Save to Logs!!

		}
    }

	// Counts how long the workout lasted.
    private static TimeSpan CountTime(DateTime startTimer, DateTime stopTimer)
    {
        TimeSpan duration = stopTimer - startTimer;
        Debug.WriteLine($"Duration: {duration}");
		
		return duration;
		
    }
}