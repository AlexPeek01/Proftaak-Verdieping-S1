﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreachingDroneElite
{
    class Suspect
    {
        string Name;
        List<string> Weapons = new List<string>();
        List<string> Utility = new List<string>();
        enum Priority {Alpha, Bravo, Charlie, Delta};
    }
}
