using GymPal.Resources.SaveToLogs;
using GymPal.Resources.ProfileSaveData;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json;

namespace GymPal.Pages;

public partial class LogsView : ContentPage
{
    
    public LogsView()
	{
		InitializeComponent();		
	}

	private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
   
}