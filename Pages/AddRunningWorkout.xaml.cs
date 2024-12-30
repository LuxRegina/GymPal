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
}