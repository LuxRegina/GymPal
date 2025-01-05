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

	private async void View2Btn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FreeweightView2());
	}
}