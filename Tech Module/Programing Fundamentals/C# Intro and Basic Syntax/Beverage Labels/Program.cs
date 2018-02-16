using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent  = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double sugar = (sugarContent / 100) * volume;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(energyContent  / 100) * volume}kcal, {(sugarContent / 100) * volume}g sugars");
        }
    }
}
