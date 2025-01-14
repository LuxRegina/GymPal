using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal.Resources.SaveToLogs
{
    public class ExerciseModel
    {
        public string? ExerciseName { get; set; }       // Benchpress
        public string? Notes { get; set; }   // I was in Spain        
        public int? Reps { get; set; }       // 15
        public int? Sets { get; set; }       // 3
        public int? Weight { get; set; }

        public override string ToString()  // Makes the Debug.WriteLine Print out correctly for testing.
        {
            return $"Exercise: {ExerciseName}, Notes: {Notes}, Sets: {Sets}, Reps: {Reps}, Weight: {Weight}";
        }

    }
}
