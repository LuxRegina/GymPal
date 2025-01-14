using GymPal.Resources.SaveToLogs;
using GymPal.Resources.ProfileSaveData;
using Microsoft.Maui.Storage;
using System.Diagnostics;
using Newtonsoft.Json;

namespace GymPal.Pages;

public partial class LogsView2 : ContentPage
{

    private string? workoutTitle = "";    
    private string? BPNotes = "";
    private int? BenchPressReps = 0;
    private int? BenchPressSets = 0;
    private int? BenchPressWeight = 0;

    private string? SquatNote = "";
    private int? SquatRep = 0;
    private int? SquatSet = 0;
    private int? SquatWeights = 0;

    private string? LPNotes = "";
    private int? LPReps = 0;
    private int? LPSets = 0;
    private int? LPWeight = 0;

    private string? DipsNote = "";
    private int? DipsRep = 0;
    private int? DipsSet = 0;
    private int? DipsWeights = 0;

    private string? SitUpsNote = "";
    private int? SitUpsRep = 0;
    private int? SitUpsSet = 0;
    private int? SitUpWeights = 0;

    private string? DLNotes = "";
    private int? DLReps = 0;
    private int? DLSets = 0;
    private int? DLWeight = 0;

    public LogsView2(string workoutName)
    {
        InitializeComponent();
        UpdateUI();
        workoutTitle = workoutName;
        NameOfWorkout.Text = workoutTitle;
        UpdateTextInUI();   

    }

    private void UpdateTextInUI()
    {
        BenchPressNotes.Text = BPNotes;
        BPReps.Text = BenchPressReps.ToString();
        BPSets.Text = BenchPressSets.ToString();
        BPWeight.Text = BenchPressWeight.ToString();

        SquatNotes.Text = SquatNote;
        SquatReps.Text = SquatRep.ToString();
        SquatSets.Text = SquatSet.ToString();
        SquatWeight.Text = SquatWeights.ToString();

        LegPressNotes.Text = LPNotes;
        LegPressReps.Text = LPReps.ToString();
        LegPressSets.Text = LPSets.ToString();
        LegPressWeight.Text = LPWeight.ToString();

        DipsNotes.Text = DipsNote;
        DipsReps.Text = DipsRep.ToString();
        DipsSets.Text = DipsSet.ToString();
        DipsWeight.Text = DipsWeights.ToString();

        SitUpNotes.Text = SitUpsNote;
        SitUpReps.Text = SitUpsRep.ToString();
        SitUpSets.Text = SitUpsSet.ToString();
        SitUpWeight.Text = SitUpWeights.ToString();

        DeadliftNotes.Text = DLNotes;
        DeadliftReps.Text = DLReps.ToString();
        DeadliftSets.Text = DLSets.ToString();
        DeadliftWeight.Text = DLWeight.ToString();

    }

    public async void HomeBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LogsView());
    }

    public void UpdateUI()
    {
        var workoutData = MainPage.LoadProgramFromJsonFile(App.fileName2);
        
        BPNotes = workoutData[0].exercise[0].Notes;
        BenchPressReps = workoutData[0].exercise[0].Reps;
        BenchPressSets = workoutData[0].exercise[0].Sets;
        BenchPressWeight = workoutData[0].exercise[0].Weight;

        SquatNote = workoutData[0].exercise[1].Notes;
        SquatRep = workoutData[0].exercise[1].Reps;
        SquatSet = workoutData[0].exercise[1].Sets;
        SquatWeights = workoutData[0].exercise[1].Weight;

        LPNotes = workoutData[0].exercise[2].Notes;
        LPReps = workoutData[0].exercise[2].Reps;
        LPSets = workoutData[0].exercise[2].Sets;
        LPWeight = workoutData[0].exercise[2].Weight;

        DipsNote = workoutData[0].exercise[3].Notes;
        DipsRep = workoutData[0].exercise[3].Reps;
        DipsSet = workoutData[0].exercise[3].Sets;
        DipsWeights = workoutData[0].exercise[3].Weight;

        SitUpsNote = workoutData[0].exercise[4].Notes;
        SitUpsRep = workoutData[0].exercise[4].Reps;
        SitUpsSet = workoutData[0].exercise[4].Sets;
        SitUpWeights = workoutData[0].exercise[4].Weight;

        DLNotes = workoutData[0].exercise[5].Notes;
        DLReps = workoutData[0].exercise[5].Reps;
        DLSets = workoutData[0].exercise[5].Sets;
        DLWeight = workoutData[0].exercise[5].Weight;




        //for (int j = 0; j < workoutData[0].exercise.Count; j++) // Loop to print all.
        //{

        //    Debug.WriteLine($"Test: {workoutData[0].exercise[j]}");
        //}
    }
}