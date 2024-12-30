﻿
namespace GymPal
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LogsBtn_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new Logs()); 
        }

        private async void ProfileBtn_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new Profile());
        }

        private async void KonditionBtn_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new Kondition());
        }
        
        // Brings user to Free weight view.
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