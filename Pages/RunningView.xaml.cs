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
}