using GymPal.Resources.SaveToLogs;
using GymPal.Resources.ProfileSaveData;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json;
using System.Collections.ObjectModel;

namespace GymPal.Pages;

public partial class LogsView : ContentPage
{

    string WorkoutName = workoutName.Text;
    
    public LogsView()
	{
		InitializeComponent();
        BindingContext = new ProgramModel();
        CollectionView collectionView = new CollectionView();
        collectionView.SetBinding(ItemsView.ItemsSourceProperty, "ExerciseList");

    }

    public void LoadLogs(ObservableCollection<ProgramModel> logsData)
    {
        if (logsData != null)
        {
            //CollectionView collectionView = new CollectionView();
            //collectionView.SetBinding(ItemsView.ItemsSourceProperty, "ExerciseList");

            WorkoutName.Text = logsData.Name;
        }
    }

    private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
   
}