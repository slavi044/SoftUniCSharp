﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
    public class Vegetable
    {
        public Vegetable(string name, int caloeries)
        {
            this.Name = name;
            this.Calories = caloeries;
        }
        public string Name { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $"  - {this.Name} have {this.Calories} calories";
        }
    }
}
