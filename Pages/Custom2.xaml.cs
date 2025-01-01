namespace GymPal.Pages;

public partial class Custom2 : ContentPage
{
	public Custom2()
	{
		InitializeComponent();
	}

	public async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Custom());
	}
}