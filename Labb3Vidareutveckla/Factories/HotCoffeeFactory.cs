﻿using Labb3Vidareutveckla.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Vidareutveckla.Factories
{
    internal class HotCoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot coffee in your cup");
            return new Coffee();
        }
    }
}
