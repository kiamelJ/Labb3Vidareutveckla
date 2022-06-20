using Labb3Vidareutveckla.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Vidareutveckla
{
    internal class Cappuccino : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Hot cappuccino is served.");
        }
    }
}
