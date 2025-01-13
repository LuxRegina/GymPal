namespace GymPal.Pages;

public partial class Custom : ContentPage
{
	public Custom()
	{
        InitializeComponent();
    }

	// Brings user back to Home view. (fungerar inte)
	/*private async void HomeBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }*/

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		//await Navigation.PushAsync(new MainPage());
	}


	private void RunGym_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Back Day and a button for start. (Starts timer)
	}

	private void FrontLegs_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Back Day and a button for start. (Starts timer)
	}

	private void PullUp_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Arm Day and a button for start. (Starts timer)
	}

	private void AssDay_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Leg Day and a button for start. (Starts timer)
	}

	private void BackDay_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Chest Day and a button for start. (Starts timer)
	}



	private async void CreateBtn_Clicked(object sender, EventArgs e)
    {
		// TBD 
		await Navigation.PushAsync(new Custom2());
	}

}