namespace GymPal;

public partial class RunningView : ContentPage
{
	public RunningView()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
	}

	private async void AddWorkoutBtn_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//AddRunningWorkout");
	}
}