using Labb3Vidareutveckla.Interfaces;
using System;

namespace Labb3Vidareutveckla
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new WarmDrinkMachine();
            IWarmDrink drink = machine.MakeDrink();
            drink.Consume();
            Console.ReadLine();
        }
    }
}
