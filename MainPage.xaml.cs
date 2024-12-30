

namespace GymPal
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

		private async void RunningButton_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//RunningView");
		}
	}

}
