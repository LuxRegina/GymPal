using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal.Resources.SavedData
{
    public class WorkoutDataModel
    {
       public List<Workout>? workouts { get; set; }
    }

    public class Workout
    {
        public string? Name { get; set; }        // CustomGym
        public TimeSpan? Duration { get; set; }    // 45 min
        public DateTime Date { get; set; }      // 12/4/24

        public List<Category>? category { get; set; }    // Cardio, FreeWeight, BodyWeight
    }

    public class Category
    {
        public List<FreeWeight>? freeWeightExercises { get; set; }  // List of exercises from free weight
        public List<BodyWeight>? bodyWeightExercises { get; set; } // List of exercises from body weight
        public List<Cardio>? cardioExercises { get; set; }        // List of exercises from cardio
    }

    public class FreeWeight
    {
        public List<FreeWeightInputData>? freeWeightInputData { get; set; }       
    }
    public class BodyWeight
    {
        public List<BodyWeightInputData>? bodyWeightInputData { get; set; }
    }
    public class Cardio
    {
        public List<CardioInputData>? cardioInputData { get; set; }
    }



    public class FreeWeightInputData
    {
        public string? ExerciseName { get; set; }       // Benchpress
        public string? Notes { get; set; }   // I was in Spain        
        public int? Reps { get; set; }       // 15
        public int? Sets { get; set; }       // 3
        public int? Weight { get; set; }     // 20

        public FreeWeightInputData(string exerciseName, string notes, int reps, int sets, int weight) 
        {
            ExerciseName = exerciseName;
            Notes = notes;
            Reps = reps;
            Sets = sets;
            Weight = weight;
		}

        public override string ToString()  // Makes the Debug.WriteLine Print out correctly for testing.
        {
            return $"Exercise: {ExerciseName}, Notes: {Notes}, Sets: {Sets}, Reps: {Reps}, Weight: {Weight}";
        }
    }

    public class BodyWeightInputData
    {
        public string? ExerciseName { get; set; }       // Sit-Ups
        public string? Notes { get; set; }   // I was in Spain        
        public int? Reps { get; set; }       // 15
        public int? Sets { get; set; }       // 3
    }

    public class CardioInputData
    {
        public string? ExerciseName { get; set; }     // Benchpress
        public string? Notes { get; set; }           // I ran on the beach        
        public string? Distance { get; set; }       // 5 km
        public string? Location { get; set; }     // Spain
        
    }
}
