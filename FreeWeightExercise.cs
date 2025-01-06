using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal
{
    public class FreeWeightExercise
    {
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public int? Sets { get; set; }
        public int? Reps { get; set; }

      

        ObservableCollection<FreeWeightExercise> Exercises = new ObservableCollection<FreeWeightExercise>
        {
            new FreeWeightExercise { Name = "Push-ups" },
            new FreeWeightExercise { Name = "Sit-Ups" },
            new FreeWeightExercise { Name = "Mountain climbers" },
            new FreeWeightExercise { Name = "High knees" },
            new FreeWeightExercise { Name = "Pistol squat" },
            new FreeWeightExercise { Name = "Squats" },
            new FreeWeightExercise { Name = "Lunges" }
        };






    }
}
