using GymPal.Pages;
using GymPal.ViewModels;
using System.Diagnostics;

namespace GymPal
{
    public partial class MainPage : ContentPage
    {
		private SharedViewModel _viewModel;
		public MainPage(SharedViewModel viewModel)
        {
            InitializeComponent();
			_viewModel = viewModel;
			BindingContext = _viewModel;
		}

        private async void RunningButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new RunningView());
		}	

        private async void LogsBtn_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new LogsView(_viewModel)); 
        }

        private async void ProfileBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfileView());
        }
        
        private async void FreeweightBtn_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new FreeweightView(_viewModel));
		}

        private async void BodyweightBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BodyWeight());
        }

        private async void CustomBtn_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new Custom());
        }
    }
}