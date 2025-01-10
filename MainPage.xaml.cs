using GymPal.Pages;
using GymPal.Resources.TempProfileSaveData;

namespace GymPal
{
    public partial class MainPage : ContentPage
    {
        public const string fileName = "ProfileData.json";

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
            await Navigation.PushAsync(new LogsView()); 
        }

        private async void ProfileBtn_Clicked(object sender, EventArgs e)
        {
            ProfileView.LoadFromJsonFile<string>(fileName);
            var profileView = new ProfileView();
            profileView.LoadProfile();
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