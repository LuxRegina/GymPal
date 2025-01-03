namespace GymPal.Pages;

public partial class BodyWeight : ContentPage
{
	public BodyWeight()
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
		await Navigation.PushAsync(new MainPage());
	}

	private async void View2Btn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BodyWeight2());
	}

}