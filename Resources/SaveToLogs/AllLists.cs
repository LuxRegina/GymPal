using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal.Resources.SaveToLogs
{
    public class AllLists
    {      
        public List<FreeWeightModel>? exercise { get; set; }    // Exercises from Free weight
        public List<BodyWeightModel>? exercise2 { get; set; }    // Exercises from Body weight
        public List<CardioModel>? exercise3 { get; set; }    // Exercises from Cardio
        
    }
}
