namespace GymPal.Pages;

public partial class LogsView : ContentPage
{
	public LogsView()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}