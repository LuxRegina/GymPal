using System.Diagnostics;
using GymPal.ViewModels;

namespace GymPal.Pages;

public partial class BodyWeight2 : ContentPage
{
	private SharedViewModel _viewModel;

	private DateTime startTimer;
    private DateTime stopTimer;

    public BodyWeight2(SharedViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
        BindingContext = _viewModel;
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
			await Task.Delay(3000);
			//await Navigation.PushAsync(new MainPage());
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