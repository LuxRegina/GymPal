namespace GymPal;

public partial class RunningView : ContentPage
{
	public RunningView()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

	private async void AddWorkoutBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AddRunningWorkout());
	}

	private void RunningFrame_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		RunForm.IsVisible = true;
	}

	private void WalkingFrame_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		WalkForm.IsVisible = true;
	}

	private void Swimming_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		SwimForm.IsVisible = true;
	}

	private void Cycling_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		CycleForm.IsVisible = true;
	}

	private void Other_Tapped(object sender, TappedEventArgs e)
	{
		FrameStack.IsVisible = false;
		OtherForm.IsVisible = true;
	}
}
