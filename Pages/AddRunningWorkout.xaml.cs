namespace GymPal;

public partial class AddRunningWorkout : ContentPage
{
	public AddRunningWorkout()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

	private async void RunningBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new RunningView());
	}

	private void RunningFrame_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible=false;
    }

	private void WalkingFrame_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
	}

	private void Swimming_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
	}

	private void Cycling_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
	}

	private void Other_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
	}
}