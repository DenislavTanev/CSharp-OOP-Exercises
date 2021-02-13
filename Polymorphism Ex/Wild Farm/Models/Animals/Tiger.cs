﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public override string ProducingSound()
        {
            return "ROAR!!!";
        }
    }
}
