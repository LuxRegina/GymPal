namespace GymPal.Pages;

public partial class FreeweightView2 : ContentPage
{
	public FreeweightView2()
	{
		InitializeComponent();
	}

	public async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FreeweightView());
	}

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
		// TBD Add timer somewhere until user presses Finish Button (that replaces the Start btn after click)
    }
}