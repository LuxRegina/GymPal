﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal.Resources.ProfileSaveData
{
    public class ProfileModel
    {
        public string? Name { get; set; }
        public int Weight { get; set; }
        public int GoalWeight { get; set; }
        public string? SpecificGoal { get; set; }

    }
}
