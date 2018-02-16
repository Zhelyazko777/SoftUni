using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string products = Console.ReadLine();
            double counter = 0;
            while (products != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {products}.");
                counter++;
                products = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
