
namespace GymPal;

public partial class BodyWeight : ContentPage
{
	public BodyWeight()
	{
		InitializeComponent();
	}

	// Brings user back to Home view.
    private async void HomeBtn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
  
}