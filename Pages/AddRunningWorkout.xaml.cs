namespace GymPal;

public partial class AddRunningWorkout : ContentPage
{
	public AddRunningWorkout()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		//await Navigation.PushAsync(new MainPage());
	}

	private async void RunningBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new RunningView());
	}

	private void RunningFrame_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible=false;
		RunForm.IsVisible=true;
    }

	private void WalkingFrame_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		WalkForm.IsVisible=true;
	}

	private void Swimming_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		SwimForm.IsVisible=true;
	}

	private void Cycling_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		CycleForm.IsVisible=true;
	}

	private void Other_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		OtherForm.IsVisible=true;
	}
}