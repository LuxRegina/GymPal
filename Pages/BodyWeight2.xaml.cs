namespace GymPal.Pages;

public partial class BodyWeight2 : ContentPage
{
	public BodyWeight2()
	{
		InitializeComponent();
	}

	public async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BodyWeight());
	}
}