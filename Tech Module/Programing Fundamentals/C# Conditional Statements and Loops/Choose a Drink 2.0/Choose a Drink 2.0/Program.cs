using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int units = int.Parse(Console.ReadLine());
            if (type == "Athlete")
            {

                Console.WriteLine($"The {type} has to pay {(units * 0.70):F2}.");
            }
            else if (type == "Businessman" || type == "Businesswoman")
            {

                Console.WriteLine($"The {type} has to pay {(units * 1.00):F2}.");
            }
            else if (type == "SoftUni Student")
            {

                Console.WriteLine($"The {type} has to pay {(units * 1.70):F2}.");
            }
            else
            {

                Console.WriteLine($"The {type} has to pay {(units * 1.20):F2}.");
            }
        }
    }
}
