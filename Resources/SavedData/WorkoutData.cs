using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal.Resources.SavedData
{
    public class WorkoutData
    {
       public List<Workout> workouts { get; set; }
    }

    public class Workout
    {
        public string Name { get; set; }        // CustomGym
        public string Duration { get; set; }    // 45 min
        public DateTime Date { get; set; }      // 12/4/24

        public List<Exercise> exercises { get; set; } // List of BenchPress, LegPress etc.
    }

    public class Exercise
    {
        public string ExerciseName { get; set; } // Benchpress

        public List<InputData> inputs { get; set; } // List of notes, reps, sets, weight
    }

    public class InputData
    {
        public string Notes { get; set; }   // I was in Spain
        public int Reps { get; set; }       // 15
        public int Sets { get; set; }       //3
        public int Weight { get; set; }     // 20
    }
}
