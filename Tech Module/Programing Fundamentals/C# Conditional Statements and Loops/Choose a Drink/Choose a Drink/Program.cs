using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (type == "Businessman" || type == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (type == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
