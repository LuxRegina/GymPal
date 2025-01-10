namespace GymPal.Pages;
using GymPal.ViewModels;

public partial class LogsView : ContentPage
{
	private SharedViewModel _viewModel;
	public LogsView(SharedViewModel viewModel)
	{
		InitializeComponent();
		
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}