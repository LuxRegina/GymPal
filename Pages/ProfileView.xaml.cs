namespace GymPal.Pages;

public partial class ProfileView : ContentPage
{
	public ProfileView()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		//await Navigation.PushAsync(new MainPage());
	}

    private void SaveBtn_Clicked(object sender, EventArgs e)
    {
		// TBD Save the info!
    }
}