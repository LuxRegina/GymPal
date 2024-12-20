
namespace GymPal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
