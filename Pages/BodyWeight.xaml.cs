namespace GymPal.Pages;

public partial class BodyWeight : ContentPage
{
	public BodyWeight()
	{
		InitializeComponent();
	}
	
	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

    private async void CoreProgram_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new BodyWeight2());
        // TBD Show Exercises in Full body program and a button for start. (Starts timer)
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