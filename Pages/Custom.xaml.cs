namespace GymPal;

public partial class Custom : ContentPage
{
	public Custom()
	{
        InitializeComponent();
    }

    // Brings user back to Home view.
    private async void HomeBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void CreateBtn_Clicked(object sender, EventArgs e)
    {
        // TBD 
    }
}