using System.Diagnostics;

namespace GymPal.Pages;

public partial class RunningView : ContentPage
{

	public RunningView()
	{
		InitializeComponent();
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

	private async void RunningFrame_Tapped(object sender, TappedEventArgs e)
	{
		await Navigation.PushAsync(new RunningView2("Run"));
	}

	private async void WalkingFrame_Tapped(object sender, TappedEventArgs e)
	{
		await Navigation.PushAsync(new RunningView2("Walk"));
	}

	private async void Swimming_Tapped(object sender, TappedEventArgs e)
	{
		await Navigation.PushAsync(new RunningView2("Swim"));
	}

	private async void Cycling_Tapped(object sender, TappedEventArgs e)
	{
		await Navigation.PushAsync(new RunningView2("Cycle"));
	}

	private async void Other_Tapped(object sender, TappedEventArgs e)
	{
		await Navigation.PushAsync(new RunningView2("Other"));
	}
}