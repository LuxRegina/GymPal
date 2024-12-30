namespace GymPal;

public partial class AddRunningWorkout : ContentPage
{
	public AddRunningWorkout()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
	}

	private async void RunningBtn_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//RunningView");
	}
}