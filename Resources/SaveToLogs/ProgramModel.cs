using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GymPal.Resources.SaveToLogs
{
    public class ProgramModel
    {
        public string? Name { get; set; }        // CustomGym
        public TimeSpan? Duration { get; set; }    // 45 min
        public DateTime Date { get; set; }      // 12/4/24
        public string Category { get; set; }    // FreeWeight, Cardio, BodyWeight

        //public List<AllLists>? exercises { get; set; }    // Exercises from all 
        public List<FreeWeightModel>? exercise { get; set; }



















        //// Add a ToString()
        //public override string ToString()  // Makes the Debug.WriteLine Print out correctly for testing.
        //{
        //    string output;
        //    output = $"Name: {Name}, Duration: {Duration}, Date: {Date}, Category: {Category}";

        //    for (int i = 0; i < exercises.Count; i++) // ner i All Lists
        //    {
        //        for (int j = 0; j <= i; j++)          // gå ner i Free weight list
        //        {
        //            output += exercises[j];
        //        }
        //    }

        //    return output;
        //}
    }
}
