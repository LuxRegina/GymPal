using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal.Resources.SaveToLogs
{
    public class ProgramModel
    {
        public string? Name { get; set; }        // CustomGym
        public TimeSpan? Duration { get; set; }    // 45 min
        public DateTime Date { get; set; }      // 12/4/24

        public List<ExerciseModel>? exercise { get; set; }    // Exercises from all
        
        // Add a ToString()
    }
}
