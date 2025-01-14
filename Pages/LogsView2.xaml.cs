using GymPal.Resources.SaveToLogs;
using GymPal.Resources.ProfileSaveData;
using Microsoft.Maui.Storage;
using System.Diagnostics;
using Newtonsoft.Json;

namespace GymPal.Pages;

public partial class LogsView2 : ContentPage
{

	private string workoutTitle;

	public LogsView2(string workoutName)
	{
        InitializeComponent();
        workoutTitle =workoutName;
	}

    public async void HomeBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LogsView());
    }
}