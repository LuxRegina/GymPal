

namespace GymPal
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void LogsBtn_Clicked(object sender, EventArgs e)
        {
          // TBD Open Logs view   
        }

        private void ProfileBtn_Clicked(object sender, EventArgs e)
        {
            // TBD Open manage profile view
        }

        private void KonditionBtn_Clicked(object sender, EventArgs e)
        {
            // TBD Open Kondition view
        }

        private async void FreeweightBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FreeweightView());
        }

        private void BodyweightBtn_Clicked(object sender, EventArgs e)
        {
            // TBD Open Bodyweight view
        }

        private void CustomBtn_Clicked(object sender, EventArgs e)
        {
            // TBD Open Custom view
        }
    }

}
