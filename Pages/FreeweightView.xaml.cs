namespace GymPal.Pages;

public partial class FreeweightView : ContentPage
{
	public FreeweightView()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

	// Navigates to FreeweightView2 and brings the name of the exercise along to next view.
	private async void FullBodyProgram_Tapped(object sender, TappedEventArgs e)
	{
		string workoutName = WorkoutName.Text;
		await Navigation.PushAsync(new FreeweightView2(workoutName));	
	}

	private void ArmDay_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Arm Day and a button for start. (Starts timer)
	}

	private void LegDay_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Leg Day and a button for start. (Starts timer)
	}

	private void ChestDay_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Chest Day and a button for start. (Starts timer)
	}

    private void BackDay_Tapped(object sender, TappedEventArgs e)
    {
        // TBD show exercises for Back Day and a button for start. (Starts timer)
    }

	private async void AddBtn_Clicked(object sender, EventArgs e)
	{
		// TBD Show All exercises with checkbox to create a new program, should contain a save workout button and option to name workout.
	}
}