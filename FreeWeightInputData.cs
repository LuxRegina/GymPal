using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal
{
    public class FreeWeightInputData
    {
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public int? Sets { get; set; }
        public int? Reps { get; set; }

      

        ObservableCollection<FreeWeightInputData> Exercises = new ObservableCollection<FreeWeightInputData>
        {
            new FreeWeightInputData { Name = "Push-ups" },
            new FreeWeightInputData { Name = "Sit-Ups" },
            new FreeWeightInputData { Name = "Mountain climbers" },
            new FreeWeightInputData { Name = "High knees" },
            new FreeWeightInputData { Name = "Pistol squat" },
            new FreeWeightInputData { Name = "Squats" },
            new FreeWeightInputData { Name = "Lunges" }
        };






    }
}
