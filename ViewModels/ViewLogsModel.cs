using GymPal.Resources.SaveToLogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GymPal.ViewModels
{
    public class LogsViewModel : INotifyPropertyChanged
    {      

        public ObservableCollection<ProgramModel> LogsList { get; set; }

        public LogsViewModel()
        {

            LogsList = new ObservableCollection<ProgramModel>
            {
                new ProgramModel { Name = "Full Body" }
                //new LogItem { WorkoutName = "Cardio", Time = "45 min", Intensity = "Medium" },
                //new LogItem { WorkoutName = "Strength", Time = "30 min", Intensity = "High" }
            };


            WorkoutName = "Full Body";
        }

        public class ProgramModel
        {
            public string? Name { get; set; }        // CustomGym
            public TimeSpan? Duration { get; set; }    // 45 min
            public DateTime Date { get; set; }      // 12/4/24
            public string Category { get; set; }    // FreeWeight, Cardio, BodyWeight

            //public List<AllLists>? exercises { get; set; }    // Exercises from all 
            public List<FreeWeightModel>? exercise { get; set; }
        }



        private string _workoutName;

        public string WorkoutName
        {
            get => _workoutName;
            set
            {
                if (_workoutName != value)
                {
                    _workoutName = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
    }
}
