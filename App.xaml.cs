using GymPal.Resources.SaveToLogs;
using GymPal.Resources.ProfileSaveData;
using Newtonsoft.Json;
using System.Diagnostics;

namespace GymPal
{
    public partial class App : Application
    {
        public const string fileName2 = "SaveToLogs.json";
        public const string fileName = "ProfileData.json";


        public App()
        {
            InitializeComponent();
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
