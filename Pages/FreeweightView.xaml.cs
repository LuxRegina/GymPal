namespace GymPal.Pages;
using GymPal.ViewModels;
using System.Diagnostics;

public partial class FreeweightView : ContentPage
{
	private SharedViewModel _viewModel;
	public FreeweightView(SharedViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
		
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage(_viewModel));
	}

	private async void FullBodyProgram_Tapped(object sender, TappedEventArgs e)
	{
		await Navigation.PushAsync(new FreeweightView2(_viewModel));
		// TBD Show Exercises in Full body program and a button for start. (Starts timer)
	}

	private void ArmDay_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Arm Day and a button for start. (Starts timer)
	}

	private void LegDay_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Leg Day and a button for start. (Starts timer)
	}

	private void ChestDay_Tapped(object sender, TappedEventArgs e)
	{
		// TBD show exercises for Chest Day and a button for start. (Starts timer)
	}

    private void BackDay_Tapped(object sender, TappedEventArgs e)
    {
        // TBD show exercises for Back Day and a button for start. (Starts timer)
    }

	private async void AddBtn_Clicked(object sender, EventArgs e)
	{
		// TBD Show All exercises with checkbox to create a new program, should contain a save workout button and option to name workout.
	}
}