using GymPal.Pages;
using GymPal.ViewModels;

namespace GymPal
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RunningButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new RunningView());
		}	

        private async void LogsBtn_Clicked(object sender, EventArgs e)
        {
			var viewModel = new SharedViewModel();
			await Navigation.PushAsync(new LogsView(viewModel)); 
        }

        private async void ProfileBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfileView());
        }
        
        private async void FreeweightBtn_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new FreeweightView());
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