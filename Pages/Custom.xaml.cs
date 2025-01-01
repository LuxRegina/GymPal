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
		await Navigation.PushAsync(new MainPage());
	}

	private async void CreateBtn_Clicked(object sender, EventArgs e)
    {
		// TBD 
		await Navigation.PushAsync(new Custom2());
	}

}