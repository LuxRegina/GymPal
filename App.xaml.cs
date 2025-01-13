
using GymPal.ViewModels;

namespace GymPal
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

			//MainPage = new AppShell();
			MainPage = new NavigationPage(new MainPage());
		}


        // Resizes the window to Android window proportions across entire App.
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 480;
            const int newHeight = 800;

            window.Width = newWidth;
            window.Height = newHeight;

            return window;

        }
    }
}
