﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Units
{
    public abstract class Unit
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double Productivity { get; set; }
    }
}
